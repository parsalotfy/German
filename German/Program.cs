using HtmlAgilityPack;
using German.PageDataClasses;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace German
{
    class Program
    {
        static void Main(string[] args)
        {


            string sitesource = null;
            using (WebClient client = new WebClient())
            {
                //sitesource = client.DownloadString("http://konjugator.reverso.net/konjugation-deutsch-verb-eingeladen.html");
                sitesource = client.DownloadString("http://konjugator.reverso.net/konjugation-deutsch-verb-studieren.html");
            }


            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(sitesource);
            htmlDocument.Save("C:/Users/Parsa/Desktop/1.html");


            MainPage einladen = htmlDocument.DocumentNode.GetEncapsulatedData<MainPage>();
            
            Console.ReadKey();

        }
    }

}
