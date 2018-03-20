using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test1_google_K
{
    class Program
    {
        static void Main(string[] args)
        {
            string _encoding = "1252";
            string path = "D:/DATA/fischerda";
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var fi in di.GetFiles("*.docx", SearchOption.AllDirectories))
            {
               

                

                string path2 = fi.DirectoryName + "\\" + fi.Name;
                Console.WriteLine(path);

                string ads  = fi.DirectoryName + "\\" + fi.Name;
                Console.WriteLine(path);
                string[] readText = File.ReadAllLines(ads);
                string polpi = "";
                foreach(string str in readText)
                {
                    polpi += str;
                }
                polpi = polpi.ToLower();
                Console.WriteLine(fi.Extension);
                

            
        }
    }
    }
}