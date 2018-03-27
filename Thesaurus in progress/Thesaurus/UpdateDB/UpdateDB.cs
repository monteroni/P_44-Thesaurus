using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;


namespace Thesaurus.UpdateDB
{
    class UpdateDB
    {
        

        [DllImport("kernel32.dll",
            EntryPoint = "GetStdHandle",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;



        public UpdateDB(string url, string part)
        {
            Console.WriteLine("This text you can see in debug output window.");

            AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
            StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);

            Console.WriteLine("This text you can see in console window.");
            udp(url, part);
        }

        private void udp(string url, string part) {

            
        // very very begining of application
        AllocConsole();
        FlushData fl = new FlushData();
            switch (part)
            {
                case "file":
                    DirectoryInfo di = new DirectoryInfo(url);
                    //WordOnTxt txt = new WordOnTxt(di);
                    FactoryFileSeparator ffs = new FactoryFileSeparator(di);
                    break;
                case "web":
                    Console.WriteLine(url);
                    
                    Web wee = new Web(url);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
