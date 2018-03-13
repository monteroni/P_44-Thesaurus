/// ETML
/// Auteur : monteroni
/// Date : 06.03.2018
/// Description : classe qui s'occupe de recuperer le code source d'une page web
using System;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace TestRecupererCodeSource
{
    class Web
    {
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
