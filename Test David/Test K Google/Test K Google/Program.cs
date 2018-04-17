using System;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;



namespace Test_K_Google
{
    class Program
    {


        static void Main(string[] args)
        {


            string[] tab = new string[] {  "C:\\Users\fischerda\\Desktop\\Temp\\" , "file" };
            FlushData fl = new FlushData();
            //switchMod(tab);
            switchMod(args);
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void switchMod(string[] args)
        {
            switch (args[1])
            {
                case "file":
                    DirectoryInfo di = new DirectoryInfo(args[0]);
                    //WordOnTxt txt = new WordOnTxt(di);
                    FactoryFileSeparator ffs = new FactoryFileSeparator(di);
                    break;
                case "web":
                    Console.WriteLine(args[0]);

                    Web wee = new Web(args[0]);
                    break;
                default:
                    break;
            }
        }

    }
}