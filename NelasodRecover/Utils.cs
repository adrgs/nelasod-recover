using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NelasodDecryptor
{
    static class Utils
    {
        public static string ByteArrayToString(byte[] byteArray, int length)
        {
            StringBuilder hex = new StringBuilder(length * 2);
            for (int i=0;i<length;i++)
                hex.AppendFormat("{0:x2}", byteArray[i]);
            return hex.ToString();
        }
    }
}
