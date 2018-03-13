using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_K_Google
{
    abstract class TemplateFileSeparator
    {
        public List<string> lstWord = new List<string>();

        public abstract string Recovery();

        public List<string> Separator(string recovery)
        {
            Char[] delimiter = new char[] { '[', ']', '#', '^', '¦', '|', '£', '<', '>', '_', '$', '\n', '\r', '.', ' ', ',', '\'', '!', '?', '(', ')', '%', '&', '"', '=', '+', '{', '}', '*', ';', ':', '\\', '-', '/' };

            String[] substrings = recovery.Split(delimiter);




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
            foreach (var word in lstWord)
                AddWord(word);
            return lstSub;
        }

        public List<Ocurrence> SettOccurence(List<string> lstSub, FileInfo fi , List<Ocurrence> lstOccurence)
        {
            List<string> lstWord2 = new List<string>();
            foreach (var substring in lstSub)
            {
                if (!lstWord2.Contains(substring))
                {
                    Ocurrence ocucu = new Ocurrence(fi, substring);
                    if (!lstOccurence.Contains(ocucu))
                    {
                        lstOccurence.Add(ocucu);
                        lstWord2.Add(substring);
                    }

                }
                else
                {
                    foreach (Ocurrence occurence in lstOccurence)
                    {
                        if (occurence.Word == substring)
                        {
                            occurence.IncreamentOccurence();
                        }
                    }


                }


            }
            return lstOccurence;
        }


        private static void AddWord(string word)
        {
            Dictionary<string, string> dicWord = new Dictionary<string, string>();
            string request = "INSERT INTO t_word (worWord) VALUES(@word);";
            dicWord.Add("@word", word);
            Connexion conec = new Connexion();
            conec.SqlCommandINSDEL(request, dicWord);
        }


    }
}
