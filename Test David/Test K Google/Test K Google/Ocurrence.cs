using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Test_K_Google
{
    class Ocurrence
    {
        private string _word, _URL, _SimpleURL;
        private int _numberOfOccurence;
        private string idFile = "", idWord = "";

        public Ocurrence(FileInfo fi, string word , string url)
        {
            this._word = word;
            if(fi == null && url.Length != 0)
            {
                this._URL = url;
            }
            else if(fi != null && url == null)
            {
                this._URL = fi.DirectoryName + "\\" + fi.Name;
                this._SimpleURL = this._URL.Replace("\\", "\\\\");
            }
            
            

            this._numberOfOccurence = 1;

            string requestWord = "SELECT idWord from t_word where `worWord`='" + _word + "';";
            string requestFile = "SELECT idFile from t_file where `filURL`='" + _SimpleURL + "';";



            Connexion conec = new Connexion();

            if (conec.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(requestFile, conec.Connection);
                //Execute command            
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idFile = reader[0].ToString();
                }
                //close connection
                conec.CloseConnection();
            }
            else
            {
                Console.WriteLine("Il y a un problème avec la connexion");
            }
            Connexion conec2 = new Connexion();
            if (conec2.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(requestWord, conec2.Connection);
                //Execute command            
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idWord = reader[0].ToString();
                }
                //close connection
                conec2.CloseConnection();
            }
            else
            {
                Console.WriteLine("Il y a un problème avec la connexion");
            }
        }



        public void IncreamentOccurence()
        {
            this._numberOfOccurence++;
        }

        public void SendToDataBase()
        {
            Dictionary<string, string> dicOcu = new Dictionary<string, string>();
            string request = "INSERT INTO t_occurence (ocuNumbre , idFile , IdWord) VALUES(@number , @file , @word);";
            dicOcu.Add("@number", this._numberOfOccurence.ToString());
            dicOcu.Add("@file", this.idFile.ToString());
            dicOcu.Add("@word", this.idWord.ToString());
            Connexion conec = new Connexion();
            conec.SqlCommandINSDEL(request, dicOcu);

        }

        private List<List<string>> SelecetId(string request)
        {
            List<List<string>> lstSELECT = new List<List<string>>();
            Connexion conec = new Connexion();
            lstSELECT = conec.SqlCommandSelect(request, null);

            return lstSELECT;
        }


        public string Word { get => _word; set => _word = value; }
        public string URL { get => _URL; set => _URL = value; }
    }
}
