using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBida
{
    public static class SecurityHelper
    {
        public const string PUBLIC_KEY = "QLBIDA";

        public static string Encrypt(string value, string publickKey)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            try
            {
                byte[] bytesIn = Encoding.UTF8.GetBytes(value);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] bytesKey = Encoding.UTF8.GetBytes(publickKey);

                Array.Resize(ref bytesKey, des.Key.Length);
                Array.Resize(ref bytesKey, des.IV.Length);

                des.Key = bytesKey;
                des.IV = bytesKey;

                using (MemoryStream msOut = new MemoryStream())
                {
                    ICryptoTransform desdecrypt = des.CreateEncryptor();
                    using (CryptoStream cryptStreem = new CryptoStream(msOut, desdecrypt, CryptoStreamMode.Write))
                    {
                        cryptStreem.Write(bytesIn, 0, bytesIn.Length);
                        cryptStreem.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(msOut.ToArray());
                }
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
