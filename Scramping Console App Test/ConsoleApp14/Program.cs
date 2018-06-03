using HtmlAgilityPack;
using ScrapySharp;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //var url = "https://www.pyszne.pl/bracia";
            var url = "https://www.pyszne.pl/restauracyjka-zacisze";
            //var url = "https://www.pyszne.pl/alle-kebab";
            //var url = "https://www.pyszne.pl/marwex-andrychow";

            // Działa tylko dla restauracji z pyszne.pl
            
            //To do: Uwaga na puste opisy 

            var webGet = new HtmlWeb();
            if (webGet.Load(url) is HtmlDocument document)
            {
                /////Nazwa

                var nazwa = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").CssSelect(".meal-name").ToArray();

                foreach (var index in nazwa)
                {
                    Console.WriteLine("Pizza: " + index.InnerText.ToString().Trim());
                }

                //////Opis

                var opis = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").CssSelect(".meal-description-additional-info").ToArray();
                foreach (var index in opis)
                {
                    Console.WriteLine("nazwa: " + index.InnerText.ToString().Trim());
                }

                //////cana

                var cena = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").CssSelect(".meal-add-btn-wrapper").ToArray();
                foreach (var index in cena)
                {
                    Console.WriteLine("Cena: " + index.InnerText.ToString().Trim());
                }

            Console.WriteLine($"Nazw - { nazwa.Count()}   Opisów - {opis.Count()}  cen - {cena.Count()}");

            }



            Console.ReadLine();
        }
    }
}
