using System;
using System.IO;

namespace NelasodDecryptor
{
    class NelasodStream
    {
        public static readonly int HEADER_LENGTH = 5;
        public static readonly int BYTES_ENCRYPTED = 153600;
        public static readonly int APPENDED_LENGTH = 78;
        public static readonly int ID_LENGTH = 40;
        public static readonly int GUID_LENGTH = 38;

        public string EncryptedPath { get; private set; }
        public string DecryptedPath { get; private set; }

        public byte[] KeyStream { get; private set; }
        public int KeyLength { get; private set; }

        public byte[] Header { get; private set; }

        public string ID { get; private set; }
        public string GUID { get; private set; }
        public string Extension { get; private set; }

        public NelasodStream(string encryptedPath, string decryptedPath)
        {
            this.EncryptedPath = encryptedPath;
            this.DecryptedPath = decryptedPath;

            byte[] encryptedFile = readFile(encryptedPath, true);
            byte[] decryptedFile = readFile(decryptedPath, false);

            this.Header = new byte[HEADER_LENGTH];
            this.Extension = new FileInfo(encryptedPath.ToLower().Replace(".nelasod","")).Extension.ToLower();
            if (this.Extension.Length==0)
            {
                this.Extension = new FileInfo(decryptedPath).Extension.ToLower();
            }

            this.KeyStream = generateKeyStream(encryptedFile, decryptedFile);
            this.KeyLength = this.KeyStream.Length;
        }

        private byte[] readFile(string filePath, bool encrypted)
        {
            byte[] buffer;

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

            long bufferLength = Math.Min(HEADER_LENGTH + BYTES_ENCRYPTED, fileInfo.Length - (encrypted == true ? APPENDED_LENGTH : 0));
            buffer = new byte[bufferLength];

            using (Stream source = File.OpenRead(filePath))
            {
                int bytesRead;
                bytesRead = source.Read(buffer, 0, buffer.Length);

                if (encrypted == true)
                {
                    byte[] idBuffer = new byte[Math.Max(ID_LENGTH,GUID_LENGTH)+1];
                    source.Seek(-APPENDED_LENGTH, SeekOrigin.End);

                    source.Read(idBuffer, 0, ID_LENGTH);
                    this.ID = System.Text.Encoding.UTF8.GetString(idBuffer).Substring(0, ID_LENGTH);

                    source.Read(idBuffer, 0, GUID_LENGTH);
                    idBuffer[GUID_LENGTH + 1] = 0;
                    this.GUID = System.Text.Encoding.UTF8.GetString(idBuffer).Substring(0, GUID_LENGTH);
                }
            }

            return buffer;
        }

        private byte[] generateKeyStream(byte[] encryptedFile, byte[] decryptedFile)
        {
            byte[] buffer;

            for (int i=0;i<HEADER_LENGTH;i++)
            {
                if (encryptedFile[i] != decryptedFile[i])
                {
                    throw new Exception("The encrypted/decrypted file pair do not match");
                }
                this.Header[i] = encryptedFile[i];
            }

            int bufferLength = Math.Min(encryptedFile.Length, decryptedFile.Length);
            buffer = new byte[bufferLength];

            for (int i=0;i<bufferLength;i++)
            {
                buffer[i] = (byte)(encryptedFile[i] ^ decryptedFile[i]);
            }

            return buffer;
        }

    }
}