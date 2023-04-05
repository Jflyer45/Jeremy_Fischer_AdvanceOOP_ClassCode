using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class UnencryptedWritercs : FileWriter
    {
        public UnencryptedWritercs(string aPath)
        {
            this.path = aPath;
        }

        protected override void DecryptFile()
        {
            // Do nothing on purpose
        }

        protected override void EncryptFile()
        {
            // Don't need to do anything
        }
    }
}
