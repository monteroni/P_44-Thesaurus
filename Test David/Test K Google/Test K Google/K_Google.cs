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
        private long fi_size;


        public K_Google()
        {

        }

        public static void AddFile(FileInfo fi)
        {
            fi_name = fi.Name;
            fi_extension = fi.Extension;
            fi_url = fi.DirectoryName;
            //fi_size = fi.Length;
        }
    }
}
