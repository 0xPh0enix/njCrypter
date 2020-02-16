using System;
using System.IO;
using System.Security.Cryptography;

namespace nAES256
{
    internal sealed class cAES256
    {
        private static byte[] bSalt = new byte[] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

        public static byte[] Encrypt(byte[] bData, byte[] bKey)
        {
            byte[] bEncrypted = null;

            using (MemoryStream mStream = new MemoryStream())
            {
                using (RijndaelManaged rmAES = new RijndaelManaged())
                {
                    rmAES.KeySize = 256;
                    rmAES.BlockSize = 128;

                    Rfc2898DeriveBytes rfcKey = new Rfc2898DeriveBytes(bKey, bSalt, 1000);

                    rmAES.Key = rfcKey.GetBytes(rmAES.KeySize / 8);
                    rmAES.IV = rfcKey.GetBytes(rmAES.BlockSize / 8);

                    rmAES.Mode = CipherMode.CBC;

                    using (CryptoStream cStream = new CryptoStream(mStream, rmAES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bData, 0, bData.Length);
                        cStream.Close();
                    }
                    bEncrypted = mStream.ToArray();
                }
            }

            return bEncrypted;
        }
        public static byte[] Decrypt(byte[] bData, byte[] bKey)
        {
            byte[] bDecrypted = null;

            using (MemoryStream mStream = new MemoryStream())
            {
                using (RijndaelManaged rmAES = new RijndaelManaged())
                {
                    rmAES.KeySize = 256;
                    rmAES.BlockSize = 128;

                    Rfc2898DeriveBytes rfcKey = new Rfc2898DeriveBytes(bKey, bSalt, 1000);

                    rmAES.Key = rfcKey.GetBytes(rmAES.KeySize / 8);
                    rmAES.IV = rfcKey.GetBytes(rmAES.BlockSize / 8);

                    rmAES.Mode = CipherMode.CBC;

                    using (CryptoStream cStream = new CryptoStream(mStream, rmAES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bData, 0, bData.Length);
                        cStream.Close();
                    }

                    bDecrypted = mStream.ToArray();
                }
            }

            return bDecrypted;
        }
    }

}