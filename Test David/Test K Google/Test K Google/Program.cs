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



            FlushData fl = new FlushData();

            DirectoryInfo di = new DirectoryInfo(@"K:\INF\Eleves\Temp\a");
            //WordOnTxt txt = new WordOnTxt(di);
            FactoryFileSeparator ffs = new FactoryFileSeparator(di);
            Console.WriteLine("Done");
            Console.ReadLine();
        }


    }
}