using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NelasodDecryptor
{
    class NelasodDecryptor
    {
        private List<NelasodStream> NelasodStreams;

        public NelasodDecryptor()
        {
            NelasodStreams = new List<NelasodStream>();
        }

        public NelasodStream GetStream(int index)
        {
            if (index > NelasodStreams.Count) return null;
            return NelasodStreams[index];
        }

        public int GetStreamsLength()
        {
            return NelasodStreams.Count;
        }

        public void AddStream(string encryptedPath, string decryptedPath)
        {
            NelasodStreams.Add(new NelasodStream(encryptedPath, decryptedPath));
        }

        public void DecryptFile(string encryptedPath, string outPath)
        {
            byte[] buffer;

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(encryptedPath);

            long bufferLength = Math.Min(NelasodStream.HEADER_LENGTH + NelasodStream.BYTES_ENCRYPTED, fileInfo.Length - NelasodStream.APPENDED_LENGTH);
            buffer = new byte[bufferLength];
            int foundIndex = -1;

            using (Stream source = File.OpenRead(encryptedPath))
            {
                int bytesRead;
                bytesRead = source.Read(buffer, 0, buffer.Length);

                byte[] idBuffer = new byte[Math.Max(NelasodStream.ID_LENGTH, NelasodStream.GUID_LENGTH) + 1];
                source.Seek(-NelasodStream.APPENDED_LENGTH, SeekOrigin.End);

                source.Read(idBuffer, 0, NelasodStream.ID_LENGTH);
                string id = System.Text.Encoding.UTF8.GetString(idBuffer).Substring(0, NelasodStream.ID_LENGTH);

                source.Read(idBuffer, 0, NelasodStream.GUID_LENGTH);
                idBuffer[NelasodStream.GUID_LENGTH + 1] = 0;
                string guid = System.Text.Encoding.UTF8.GetString(idBuffer).Substring(0, NelasodStream.GUID_LENGTH);

                for (int i=0;i<NelasodStreams.Count;i++)
                {
                    if (guid != NelasodStreams[i].GUID) continue;
                    if (id != NelasodStreams[i].ID) continue;

                    foundIndex = -2;

                    for (int j=0;j<NelasodStream.HEADER_LENGTH;j++)
                    {
                        if (NelasodStreams[i].Header[j] != buffer[j]) break;

                        if (j==NelasodStream.HEADER_LENGTH-1)
                        {
                            if (bufferLength > NelasodStreams[i].KeyLength && foundIndex < 0)
                            {
                                foundIndex = -3;
                            }
                            else { 
                                foundIndex = i;
                            }
                        }
                    }
                }

                if (foundIndex == -1)
                {
                    throw new Exception(String.Format("The ID/GUID of the encrypted file ({0}) was not found in the pairs",id+guid));
                }
                if (foundIndex == -2)
                {
                    throw new Exception(String.Format("The header ({0}) was not found in the pairs", Utils.ByteArrayToString(buffer, NelasodStream.HEADER_LENGTH)));
                }
                if (foundIndex == -3)
                {
                    throw new Exception(String.Format("The provided pairs were not long enough to decrypt this file", Utils.ByteArrayToString(buffer, NelasodStream.HEADER_LENGTH)));
                }

            }

            File.Copy(encryptedPath, outPath);

            using (Stream destination = File.OpenWrite(outPath))
            {
                for (int i=0; i < bufferLength;i++)
                {
                    destination.WriteByte((byte)(NelasodStreams[foundIndex].KeyStream[i] ^ buffer[i]));
                }
            }

            long newLength = new FileInfo(outPath).Length - NelasodStream.APPENDED_LENGTH;
            using (FileStream fileStream = new FileStream(outPath, FileMode.OpenOrCreate))
            {
                fileStream.SetLength(newLength);
            }
        }
    }
}
