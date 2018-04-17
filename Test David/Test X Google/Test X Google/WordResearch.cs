using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_X_Google
{
    class WordResearch
    {
        private string word, idword;
        private string[] occurences;
        
        public WordResearch(string word)
        {
            getIdWord(word);
            if (idword != null)
            {
                Console.WriteLine(idword + " " + word);
                //getOccurence(idword);
            }

        }
        private void getIdWord(string word)
        {
            Dictionary<string, string> dicWord = new Dictionary<string, string>();
            string request = "SELECT `IdWord` FROM `t_word` WHERE worWord='@word';";
            dicWord.Add("@word", word);
            Connexion conec = new Connexion();
            List<List<string>> lllst = conec.SqlCommandSelect(request, dicWord);
            if (lllst.Count != 0)
            {
                idword = lllst[0][0];
            }
        }
        private void getOccurence(string idWord)
        {
            Dictionary<string, string> dicWord = new Dictionary<string, string>();
            string request = "SELECT `IdWord` FROM `t_word` WHERE worWord='@word';";
            dicWord.Add("@word", word);
            Connexion conec = new Connexion();
            List<List<string>> lllst = conec.SqlCommandSelect(request, dicWord);
            if (lllst != null)
            {
                idword = lllst[0][0];
            }
        }
    }
}
