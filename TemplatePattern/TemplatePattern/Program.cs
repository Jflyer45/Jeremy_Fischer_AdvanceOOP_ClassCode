//Jeremy Fischer
using System;

namespace TemplatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileWriter fw = new DESWriter("C:\\Users\\jflye\\source\\repos\\AdvanceOOP_ClassCode\\TemplatePattern\\TemplatePattern\\encrypted.txt");
            fw.Append("All work and no plasy makes Jack a dull boy.");

            FileWriter fw2 = new UnencryptedWritercs("C:\\Users\\jflye\\source\\repos\\AdvanceOOP_ClassCode\\TemplatePattern\\TemplatePattern\\unencrypted.txt");
            fw2.Append("All work and no plasy makes Janice a dull Girl.");

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
