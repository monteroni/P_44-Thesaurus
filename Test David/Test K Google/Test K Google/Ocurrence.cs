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
        private string _word, _URL , _SimpleURL;
        private int _numberOfOccurence;
        private int idFile, idWord;

        public Ocurrence(FileInfo fi, string word)
        {
            this._word = word;
            this._URL = fi.DirectoryName + "\\" + fi.Name;
            this._SimpleURL =  this._URL.Replace("\\" , "\\\\");
            
            this._numberOfOccurence = 1;

            this.idFile = SelecetId("idFile", "t_file", _SimpleURL, "filURL");
            this.idWord = SelecetId("IdWord", "t_word", _word, "worWord");
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
            conec.SqlCommand(request, dicOcu);

        }

        private int SelecetId(string id, string table, string word, string where)
        {
            string query = "SELECT " + id + " from " + table + " where `" + where + "`='" + word + "';";
            Connexion conec = new Connexion();

            conec.OpenConnection();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conec.Connection);

            //Execute command
            int result = cmd.ExecuteNonQuery();
            // result gives the -1 output.. but on insert its 1


            //close connection
            conec.CloseConnection();

            return result;
        }


        public string Word { get => _word; set => _word = value; }
        public string URL { get => _URL; set => _URL = value; }
    }
}
