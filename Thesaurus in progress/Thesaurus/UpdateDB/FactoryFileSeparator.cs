using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus.UpdateDB
{
    class FactoryFileSeparator
    {
        public FactoryFileSeparator(DirectoryInfo di)
        {
            foreach (var fi in di.GetFiles("*.txt", SearchOption.AllDirectories))
            {
                K_Google.AddFile(fi);
                FileSeprator(fi);
            }
        }


        public TemplateFileSeparator FileSeprator(FileInfo fi)
        {
            switch(fi.Extension)
            {
                case ".txt":
                    return new TxtSeparator(fi);

                default:
                    return new TxtSeparator(fi);
            }
        }
    }
}
