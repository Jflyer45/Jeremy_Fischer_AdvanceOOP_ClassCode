using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace TemplatePattern
{
    public class DESWriter : FileWriter
    {
        private const string key = "1231sdfdhgfdgfsdvbfdgdsffcvb";

        public DESWriter(string aPath)
        {
            this.path = aPath;
        }
        protected override void DecryptFile()
        {
            if (File.Exists(path))
            {
                using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
                {
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    ICryptoTransform desDecrypt = DES.CreateDecryptor();
                    CryptoStream cryptoStreamDecr = new CryptoStream(fs, desDecrypt, CryptoStreamMode.Read);

                    StreamWriter fsDecrypted = new StreamWriter("C:\\Users\\jflye\\source\\repos\\AdvanceOOP_ClassCode\\TemplatePattern\\TemplatePattern\\temp.txt");
                    fsDecrypted.Write(new StreamReader(cryptoStreamDecr).ReadToEnd());
                    fsDecrypted.Flush();
                    fsDecrypted.Close();
                }
            }
        }

        protected override void AppendFile(string data)
        {
            using (FileStream fs = File.Open("C:\\Users\\jflye\\source\\repos\\AdvanceOOP_ClassCode\\TemplatePattern\\TemplatePattern\\temp.txt", FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        protected override void EncryptFile()
        {
            if (File.Exists(path))
            {
                using (FileStream fs = File.Open(path, FileMode.Open))
                {
                    FileStream fsEncrypted = new FileStream(path, FileMode.Create, FileAccess.Write);


                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    ICryptoTransform desEncrypt = DES.CreateEncryptor();
                    CryptoStream cryptoStreamDecr = new CryptoStream(fs, desEncrypt, CryptoStreamMode.Read);

                    byte[] byteArrayInput = new byte[fs.Length];
                    cryptoStreamDecr.Write(byteArrayInput, 0, byteArrayInput.Length);
                    cryptoStreamDecr.Close();
                    fs.Close();
                    fsEncrypted.Close();
                }
            }
        }
    }
}
