using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace TestRecupererCodeSource
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Web html = new Web();
            // Adresse recherchée par l'utilisateur
            string AdressResearch = "";
            // Code source de la page ayant l'adresse "AdressResearch"
            string myText = "";
            // Séparateur de mot
            Char[] delimiter;
            // Tableau stockant les mots
            String[] substrings;
            // Regex controlant si l'url rentré par l'utilisateur est bien une url
            Regex urlRegex = new Regex("(http|https):\\/\\/(\\w+:{0,1}\\w*@)?(\\S+)(:[0-9]+)?(\\/|\\/([\\w#!:.?+=&%@!\\-]))?");
            using (WebClient webClient = new WebClient())
            {
                do
                {
                    Console.Clear();
                    Console.Write("Entrer l'adresse du site que vous voulez recuperer : ");
                    AdressResearch = Console.ReadLine();
                    // Si l'adresse est bien un url recupere le code source et en garde que le text 
                    if (AdressResearch != ""&& urlRegex.IsMatch(AdressResearch))
                    {
                        Uri uri = new Uri(AdressResearch);
                        myText = html.getTextInHTML(uri);
                        myText = myText.ToLower();
                        delimiter = new char[] { '[', ']', '#', '^', '¦', '|', '£', '<', '>', '_', '$', '\n', '\r', '.', ' ', ',', '\'', '!', '?', '(', ')', '%', '&', '"', '=', '+', '{', '}', '*', ';', ':', '\\', '-', '/' };
                        substrings = myText.Split(delimiter);
                        for (int x = 0; x < substrings.Length; x++)
                        {
                            File.AppendAllText("G:/test.txt",substrings[x]+Environment.NewLine);
                            Console.WriteLine(substrings[x]);
                        }
                    }
                    Console.Read();
                } while (true);
            }
        }
    }
}
