﻿/// ETML
/// Auteur : monteroni
/// Date : 06.03.2018
/// Description : classe qui s'occupe de recuperer le code source d'une page web
using System;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace TestRecupererCodeSource
{
    class Web
    {
        public Web(string url)
        {
            List<string> lstSub = new List<string>();
            
            // Séparateur de mot
            Char[] delimiter = new char[] { '[', ']', '#', '^', '¦', '|', '£', '<', '>', '_', '$', '\n', '\r', '.', ' ', ',', '\'', '!', '?', '(', ')', '%', '&', '"', '=', '+', '{', '}', '*', ';', ':', '\\', '-', '/' };
            // Tableau stockant les mots
            String[] substrings;
            // Regex controlant si l'url rentré par l'utilisateur est bien une url
            Regex urlRegex = new Regex("(http|https):\\/\\/(\\w+:{0,1}\\w*@)?(\\S+)(:[0-9]+)?(\\/|\\/([\\w#!:.?+=&%@!\\-]))?");
            using (WebClient webClient = new WebClient())
            {

                // Si l'adresse est bien un url recupere le code source et en garde que le text 
                if (url != "" && urlRegex.IsMatch(url))
                {
                    Uri uri = new Uri(url);
                    string myText = getTextInHTML(uri);
                    myText.ToLower();
                    
                    substrings = myText.Split(delimiter);
                    for (int x = 0; x < substrings.Length; x++)
                    {
                        lstSub.Add(substrings[x]);
                        //File.AppendAllText("G:/test.txt", substrings[x] + Environment.NewLine);
                        Console.WriteLine(substrings[x]);
                    }
                }
                Console.Read();

            }
        }


        /// <summary>
        /// Methode recupérant le code source d'une page web et garde que le text de celle-ci
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string getTextInHTML(Uri url)
        {
            var html = new WebClient().DownloadString(url);
            var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            html = regexCss.Replace(html, string.Empty);
            html = html.Replace("&nbsp;", string.Empty);
            Regex regEx = new Regex("<[^>]*>", RegexOptions.IgnoreCase);
            html = regEx.Replace(html, String.Empty);
            html = Regex.Replace(html, @"\n", String.Empty);
            html = Regex.Replace(html, @"\r", " ");
            html = Regex.Replace(html, @"\t", " ");
            html = Regex.Replace(html, @"^((\<!--\s*.*?((--\>)|$))|\\n|<.*?>)", String.Empty);
            byte[] bytes = Encoding.Default.GetBytes(html);
            html = Encoding.UTF8.GetString(bytes);
            html = Regex.Replace(html, @"[ ]{2,}", " ");
            return html;
        }
    }
}
