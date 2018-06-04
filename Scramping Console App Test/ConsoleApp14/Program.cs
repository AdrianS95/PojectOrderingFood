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
    public class Model
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Cena { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //tring url = "https://www.pyszne.pl/bracia";
            //var url = "https://www.pyszne.pl/restauracyjka-zacisze";
            var url = "https://www.pyszne.pl/alle-kebab";
            //var url = "https://www.pyszne.pl/marwex-andrychow";
            Console.WriteLine(DateTime.Now.Ticks);
            var webGet = new HtmlWeb();
            if (webGet.Load(url) is HtmlDocument document)
            {

                var sektor = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").ToArray();
                var mod = new List<Model>();



                    foreach (var item in sektor)
                    {
                        var nazwa = item.CssSelect(".meal-name");
                        var opis = item.CssSelect(".meal-description-additional-info");
                        var cena = item.CssSelect(".meal-add-btn-wrapper");

                        foreach (var i in nazwa)
                        {
                            Console.WriteLine(i.InnerText.Trim());
                        }

                        foreach (var i in opis)
                        {
                            Console.WriteLine(i.InnerText.Trim());
                        }

                        foreach (var i in cena)
                        {
                            Console.WriteLine(i.InnerText.Trim());
                        }


                        Console.WriteLine();

                    }

            }


            //var webGet = new HtmlWeb();
            //if (webGet.Load(url) is HtmlDocument document)
            //{
            //    var sektor = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").ToArray();

            //    foreach (var item in sektor)
            //    {
            //        var nazwa = item.CssSelect(".meal-name");
            //        var opis = item.CssSelect(".meal-description-additional-info");
            //        var cena = item.CssSelect(".meal-add-btn-wrapper");

            //        foreach (var i in nazwa)
            //        {
            //            Console.WriteLine(i.InnerText.Trim());
            //        }

            //        foreach (var i in opis)
            //        {
            //            Console.WriteLine(i.InnerText.Trim());
            //        }

            //        foreach (var i in cena)
            //        {
            //            Console.WriteLine(i.InnerText.Trim());
            //        }

            //        Console.WriteLine();

            //    }





            /////Nazwa

            //var nazwa = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").CssSelect(".meal-name").ToArray();

            //foreach (var index in nazwa)
            //{
            //    Console.WriteLine("Pizza: " + index.InnerText.ToString().Trim());
            //}

            //////Opis

            //var opis = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").CssSelect(".meal-description-additional-info").ToArray();
            //foreach (var index in opis)
            //{
            //    Console.WriteLine("nazwa: " + index.InnerText.ToString().Trim());
            //}

            //////cana

            //var cena = document.DocumentNode.CssSelect(".menucard").CssSelect(".meal").CssSelect(".meal-add-btn-wrapper").ToArray();
            //foreach (var index in cena)
            //{
            //    Console.WriteLine("Cena: " + index.InnerText.ToString().Trim());
            //}

            //Console.WriteLine($"Nazw - { nazwa.Count()}   Opisów - {opis.Count()}  cen - {cena.Count()}");
            Console.WriteLine(DateTime.Now.Ticks);
            Console.ReadLine();
        }

    }

}





