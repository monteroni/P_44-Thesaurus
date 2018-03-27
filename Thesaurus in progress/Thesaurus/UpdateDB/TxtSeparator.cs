using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Thesaurus.UpdateDB
{
    class TxtSeparator : TemplateFileSeparator
    {
        string _encoding = "Windows-1252";
        public TxtSeparator(FileInfo fi)
        {
            GetUpdate(fi);
        }
        public override void GetUpdate(FileInfo fi)
        {
            SetOccurence(Separator(Recovery(fi)) , fi , lstOccurence , null);

        }
        public override string Recovery(FileInfo fi)
        {
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
            return polpi;
        }
    }
}
