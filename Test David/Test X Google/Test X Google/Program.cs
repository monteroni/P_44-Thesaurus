using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_X_Google
{
    class Program
    {
        
        static void Main(string[] args)
        {
            research(Console.ReadLine());
        }
        public static void research (string res)
        {
            X_Google xg = new X_Google(res);
        }
    }
}
