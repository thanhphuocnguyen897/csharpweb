using System;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Text.Unicode;

namespace Regex_Practise3
{
    class CrawlALink
    {
        static void Main(string[] args)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument document = htmlWeb.Load("https://www.nhaccuatui.com/bai-hat/nhac-tre-moi.html");
            //Load <li> tag in <ul> tag.
            var listGerne = document.DocumentNode.SelectNodes("//ul[@class='listGenre']/li").ToList();
            foreach(var item in listGerne)
            {
                Match match = Regex.Match(item.InnerHtml, @"<\s*a[^>]*>(.*?)");
                string titleAttribute = Regex.Match(match.Value, @"title+\W\D+").Value;
                titleAttribute = titleAttribute.Replace("\"", "'");
                string songName = Regex.Match(titleAttribute, @"'+\w+\D+\s").Value.Replace("'", "");
                Console.OutputEncoding = System.Text.Encoding.UTF8;  //Option 2    
                Console.WriteLine(songName);
            }
        }
    }
}
