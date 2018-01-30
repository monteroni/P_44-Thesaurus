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
            DirectoryInfo di = new DirectoryInfo(@"K:\INF\Eleves\Temp");
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
            Console.WriteLine();

            Console.WriteLine("Search pattern AllDirectories returns:");
            foreach (var fi in di.GetFiles("*.txt", SearchOption.AllDirectories))
            {
                
                string path = fi.DirectoryName +"\\"+ fi.Name;
                Console.WriteLine(path);
                string polpi = System.IO.File.ReadAllText(path);
                Console.WriteLine(polpi);
                Console.WriteLine();
                
                Console.WriteLine();
                Thread.Sleep(400);
            }
        }
    }
}
