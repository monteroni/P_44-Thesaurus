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
        private List<Ocurrence> lstOccurence = new List<Ocurrence>();
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
                foreach (var word in lstWord)
                    AddWord(word);
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
                
                
            }
            foreach (Ocurrence ocu in lstOccurence)
                ocu.SendToDataBase();
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

