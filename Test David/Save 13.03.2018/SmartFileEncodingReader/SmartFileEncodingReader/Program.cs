using KlerksSoft;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFileEncodingReader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> files = new List<string>();
            files.Add("ansi.txt");
            files.Add("utf8.txt");
            /*
            StreamReader ansi = new StreamReader("ansi.txt");
            StreamReader utf8 = new StreamReader("utf8.txt");

            string ansiContent = ansi.ReadToEnd();
            string utf8Content = utf8.ReadToEnd();

            Console.WriteLine("ansi : " + ansi.CurrentEncoding.CodePage);
            //Console.WriteLine("ansi 2: "+TextFileEncodingDetector.DetectTextFileEncoding("ansi.txt"));
            //Console.WriteLine(ansiContent);


            Console.WriteLine("utf8 : " + utf8.CurrentEncoding.CodePage);
            //Console.WriteLine(utf8Content);
            */


            foreach (string file in files)
            {
                Console.Write(file);
                string filename = file;
                using (FileStream fs = File.OpenRead(filename))
                {
                    Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                    cdet.Feed(fs);
                    cdet.DataEnd();
                    if (cdet.Charset != null)
                    {
                        Console.WriteLine("Charset: {0}, confidence: {1}",
                             cdet.Charset, cdet.Confidence);
                    }
                    else
                    {
                        Console.WriteLine("Detection failed.");
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
