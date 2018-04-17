using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_X_Google
{
    class X_Google
    {
        private Char[] delimiter = new char[] { '[', ']', '#', '^', '¦', '|', '£', '<', '>', '_', '$', '\n', '\r', '.', ' ', ',', '\'', '!', '?', '(', ')', '%', '&', '"', '=', '+', '{', '}', '*', ';', ':', '\\', '-', '/' };
        private string research;
        public X_Google(string research)
        {
            this.research = research;
            Research(research);
        }
        private void Research (string research)
        {
            WordResearch wr;
            String[] substrings = research.Split(delimiter);
            foreach(string str in substrings)
            {
                wr = new WordResearch(str);
            }
        }

    }
}
