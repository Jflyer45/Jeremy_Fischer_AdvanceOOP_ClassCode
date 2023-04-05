using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TemplatePattern
{
    public abstract class FileWriter
    {
        protected string path = "C:\\Users\\jflye\\source\\repos\\AdvanceOOP_ClassCode\\TemplatePattern\\TemplatePattern\\test.txt";

        protected abstract void DecryptFile();

        protected virtual void AppendFile(string data)
        {
            using (FileStream fs = File.Open(path, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        protected abstract void EncryptFile();

        public void Append(string data)
        {
            this.DecryptFile();
            this.AppendFile(data);
            this.EncryptFile();
        }
    }
}
