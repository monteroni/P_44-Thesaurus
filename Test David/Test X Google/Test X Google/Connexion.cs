﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Test_X_Google
{
    class Connexion
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection Connection { get => connection; set => connection = value; }

        //Constructor
        public Connexion()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "db_thesaurus";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }

        }

        //Close connection
        public string CloseConnection()
        {
            try
            {
                connection.Close();
                return null;
            }
            catch (MySqlException ex)
            {
                return ex.Message;

            }
        }

        

        //SqlCommandSELECT
        public List<List<string>> SqlCommandSelect(string query, Dictionary<string, string> dico)
        {
            List<List<string>> lstSELECT = new List<List<string>>();
            //open connection
            if (this.OpenConnection() == true)
            {                
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (dico != null)
                {
                    foreach (KeyValuePair<string, string> kvp in dico)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }
                    //prepare the command
                    cmd.Prepare();
                }
                //Execute command                
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<string> lst = new List<string>();
                    foreach (var v in reader)
                    {
                        lst.Add(v.ToString());
                        
                    }
                    lstSELECT.Add(lst);

                }
                //close connection
                this.CloseConnection();       
            }
            return lstSELECT;
        }
    }
}
