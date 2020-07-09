using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Almwdeh.Functions
{
    public static class Crypto
    {
        public static string Hash(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(value))
                );
        }

        public static String Decrypt(String decryptstr)
        {
            string decrypted = string.Empty;
            try
            {
                byte[] data = System.Convert.FromBase64String(decryptstr);
                byte[] rgbKey = System.Text.ASCIIEncoding.ASCII.GetBytes("vY7q-3Os");
                byte[] rgbIV = System.Text.ASCIIEncoding.ASCII.GetBytes("_1pCq7Yw");

                MemoryStream memoryStream = new MemoryStream(data.Length);
                DESCryptoServiceProvider desCryptoServiceProvider = new DESCryptoServiceProvider();
                ICryptoTransform x = desCryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, x, CryptoStreamMode.Read);
                memoryStream.Write(data, 0, data.Length);

                memoryStream.Position = 0;
                decrypted = new StreamReader(cryptoStream).ReadToEnd();
                cryptoStream.Close();
                memoryStream.Dispose();
                return decrypted;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}