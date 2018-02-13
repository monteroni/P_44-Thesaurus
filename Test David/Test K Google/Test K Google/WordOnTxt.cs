using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_K_Google
{
    class WordOnTxt
    {
        public WordOnTxt(DirectoryInfo di)
        {
            string _encoding = "1252";
            foreach (var fi in di.GetFiles("*.txt", SearchOption.AllDirectories))
            {
                K_Google.AddFile(fi);


                List<string> lstWord = new List<string>();

                using (FileStream fs = File.OpenRead(fi.FullName))
                {
                    Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                    cdet.Feed(fs);
                    cdet.DataEnd();
                    if (cdet.Charset != null)
                    {
                        _encoding = cdet.Charset;
                        //Console.WriteLine(_encoding);
                    }
                    else
                    {
                        Console.WriteLine("Detection failed.");
                    }
                }

                string path = fi.DirectoryName + "\\" + fi.Name;
                Console.WriteLine(path);
                StreamReader Reader = new StreamReader(path, Encoding.GetEncoding(_encoding));
                string polpi = Reader.ReadToEnd();
                Reader.Close();
                polpi = polpi.ToLower();





                Char[] delimiter = new char[] { '[', ']', '#', '^', '¦', '|', '£', '<', '>', '_', '$', '\n', '\r', '.', ' ', ',', '\'', '!', '?', '(', ')', '%', '&', '"', '=', '+', '{', '}', '*', ';', ':', '\\', '-', '/' };

                String[] substrings = polpi.Split(delimiter);




                //List<string> lstSub = new List<string>(substrings);

                List<string> lstSub = new List<string>();

                foreach (string word in substrings)
                {
                    if (word.Count() > 0)
                        lstSub.Add(word);
                }
                lstSub.Sort();



                foreach (var substring in lstSub)
                {
                    if (!lstWord.Contains(substring))
                    {
                        lstWord.Add(substring);
                    }


                }
                lstSub.Sort();
                foreach (var substring in lstWord)
                    AddWord(substring);

            }
        }
        private static void AddWord(string word)
        {
            string request = "INSERT INTO t_word (worWord) VALUES('" + word + "');";
            Connexion conec = new Connexion();
            conec.SqlCommand(request);
        }
    }
}
