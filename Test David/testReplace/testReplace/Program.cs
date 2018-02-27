using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "salut\\\\sava?";
            Console.WriteLine(test);
            string test2 = test.Replace("\\\\" , "\\");
            Console.WriteLine(test2);

        }
    }
}
