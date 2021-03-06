﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_K_Google
{
    class K_Google
    {

        private static Connexion conec = new Connexion();

        

        public static void AddFile(FileInfo fi)
        {
            Dictionary<string, string> dicFile = new Dictionary<string, string>();
            dicFile.Add( "@name",fi.Name);
            dicFile.Add("@extension", fi.Extension);
            dicFile.Add("@url", fi.DirectoryName + "\\" + fi.Name);
            dicFile.Add("@size", fi.Length.ToString());
            

            string request = "INSERT INTO t_file (filName , filSize , filExtend , filURL) VALUES ( @name, @size , @extension , @url);";
            conec.SqlCommandINSDEL(request , dicFile);
        }
        public static void AddWeb(string url)
        {
            string[] strName = new string[2];
            
            Dictionary<string, string> dicFile = new Dictionary<string, string>();
            for(int i = 0; i < 2; i++)
            {
                strName = url.Split('.');
            }
            
            dicFile.Add("@name", strName[1]);
            
            dicFile.Add("@url", url);
            


            string request = "INSERT INTO t_file (filName , filURL) VALUES ( @name, @url);";
            conec.SqlCommandINSDEL(request, dicFile);
        }
    }
}
/*
 * foreach( KeyValuePair<string, string> kvp in myDictionary )
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}
*/