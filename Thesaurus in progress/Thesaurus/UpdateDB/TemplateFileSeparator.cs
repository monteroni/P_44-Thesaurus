using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus.UpdateDB
{
    abstract class TemplateFileSeparator
    {
        /// <summary>
        /// tableau des caractères qui va nous servir à séparer les mots
        /// </summary>
        private Char[] delimiter = new char[] { '[', ']', '#', '^', '¦', '|', '£', '<', '>', '_', '$', '\n', '\r', '.', ' ', ',', '\'', '!', '?', '(', ')', '%', '&', '"', '=', '+', '{', '}', '*', ';', ':', '\\', '-', '/' };
        public List<Ocurrence> lstOccurence = new List<Ocurrence>();
        public List<string> lstWord = new List<string>();
        /// <summary>
        /// méthode permettant de mettre à jour la base de donnée
        /// </summary>
        public abstract void GetUpdate(FileInfo fi);

        /// <summary>
        /// Méthode de récupération du contenu dans un string
        /// </summary>
        /// <returns>contenu d'un fichier</returns>
        public abstract string Recovery(FileInfo fi);
        /// <summary>
        /// Méthode permettant de séparer tout les mots
        /// </summary>
        /// <param name="recovery">text brut</param>
        /// <returns>liste de mots séparé</returns>
        public List<string> Separator(string recovery)
        {
            String[] substrings = recovery.Split(delimiter);
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
        /// <summary>
        /// méthode permettant de lister les Occurences et de leurs incrémentations
        /// </summary>
        /// <param name="lstSub">liste des mots séparés</param>
        /// <param name="fi">fichier dans lequel l'occurence à été trouvée</param>
        /// <param name="lstOccurence">liste des occurences</param>
        /// <returns>la liste des occurences remplie</returns>
        public void SetOccurence(List<string> lstSub, FileInfo fi , List<Ocurrence> lstOccurence , string WebUrl)
        {
            List<string> lstWord2 = new List<string>();
            foreach (var substring in lstSub)
            {
                if (!lstWord2.Contains(substring))
                {
                    Ocurrence ocucu = new Ocurrence(fi, substring , WebUrl);
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
            foreach (Ocurrence ocu in lstOccurence)
                ocu.SendToDataBase();
        }
        /// <summary>
        /// Méthode permettant d'ajouter les mots dans la base de donnée
        /// </summary>
        /// <param name="word">le mot à ajouter</param>
        public static void AddWord(string word)
        {
            Dictionary<string, string> dicWord = new Dictionary<string, string>();
            string request = "INSERT INTO t_word (worWord) VALUES(@word);";
            dicWord.Add("@word", word);
            Connexion conec = new Connexion();
            conec.SqlCommandINSDEL(request, dicWord);
        }


    }
}
