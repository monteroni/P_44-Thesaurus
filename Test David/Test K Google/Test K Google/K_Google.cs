using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_K_Google
{
    class K_Google
    {
        private static string fi_name, fi_url, fi_extension;
        private static long fi_size;
        private static Connexion conec = new Connexion();

        

        public static void AddFile(FileInfo fi)
        {
            Dictionary<string, string> dicFile = new Dictionary<string, string>();
            dicFile.Add( "@name",fi.Name);
            dicFile.Add("@extension", fi.Extension);
            dicFile.Add("@url", fi.DirectoryName + "\\" + fi.Name);
            dicFile.Add("@size", fi.Length.ToString());
            string request = "INSERT INTO t_file (filName , filSize , filExtend , filURL) VALUES ( '" + fi_name + "', '" + fi_size + "' , '" + fi_extension + "' , '" + fi_url + "');";
            request = "INSERT INTO t_file (filName , filSize , filExtend , filURL) VALUES ( @name, @size , @extension , @url);";
            conec.SqlCommand(request , dicFile);
        }
    }
}
/*
 * foreach( KeyValuePair<string, string> kvp in myDictionary )
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}
*/