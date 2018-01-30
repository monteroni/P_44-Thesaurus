using System;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;

namespace Test_K_Google
{
    class Program
    {


        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"K:\INF\Eleves\Temp\Thesaurus");
            #region
            /*Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.DirectoryName + "\\"+ fi.Name);
            }

            Console.WriteLine();*/

            //      string text = System.IO.File.ReadAllText(@"K:\INF\Eleves\Temp\Arborescence-Projet-Web.bat");

            // Display the file contents to the console. Variable text is a string.
            //      System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            ////////////Application wordApp = new Application();
            ////////////Document word = wordApp.Documents.Open(_path);
            ////////////List<string> theText = new List<string>();
            ////////////foreach (Range tmpRange in word.StoryRanges)
            ////////////{
            ////////////    theText.Add(tmpRange.Text);
            ////////////}
            ////////////word.Close();
            ////////////wordApp.Quit();
            ////////////string text = theText[0];
            ////////////text = text.Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ");
            ////////////string[] allWords = text.Split(' ');

#endregion


            /*
            Console.WriteLine("Search pattern *2* returns:");
            foreach (var fi in di.GetFiles("*2*"))
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Search pattern test?.txt returns:");
            foreach (var fi in di.GetFiles("test?.txt"))
            {
                Console.WriteLine(fi.Name);
                
            }
            */
            // Console.WriteLine();
            string _encoding = "1252";
            Console.WriteLine("Search pattern AllDirectories returns:");
            foreach (var fi in di.GetFiles("*.txt", SearchOption.AllDirectories))
            {
                using (FileStream fs = File.OpenRead(fi.FullName))
                {
                    Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                    cdet.Feed(fs);
                    cdet.DataEnd();
                    if (cdet.Charset != null)
                    {
                        _encoding = cdet.Charset;
                        Console.WriteLine(_encoding);
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








                Char delimiter = ' ';
                String[] substrings = polpi.Split(delimiter  , '\r');
                

                Array.Sort(substrings);



                List<string> lstSub = new List<string>(substrings);





                for (int i = 0; i < lstSub.Count; i++)
                {
                    lstSub[i] = lstSub[i].ToLower();
                    if (lstSub[i][0] == ' ' || lstSub[i][0] == '!' || lstSub[i][0] == '?' || lstSub[i][0] == '.' || lstSub[i][0] == '\\')
                    {
                        
                        lstSub.Remove(lstSub[i]);
                    }
                }



                foreach (var substring in lstSub)
                    Console.WriteLine(substring);



                Thread.Sleep(400);
            }
        }
    }
}
