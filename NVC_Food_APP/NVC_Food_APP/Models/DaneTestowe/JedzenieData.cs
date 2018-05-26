using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NVC_Food_APP.Models;
using NVC_Food_APP.Migrations;
using System.Data.Entity.Migrations;

namespace NVC_Food_APP.Models.DaneTestowe
{ 
    public class JedzenieData : MigrateDatabaseToLatestVersion<JedzenieDbContext, Configuration>
    {

        public static void SeedJedzenieData(JedzenieDbContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaID = 1, NazwaKategorii = "Pizza", NazwaPlikuIkony = "Pizza.png", Opiskategorii = "Mniam Pizza"},
                new Kategoria(){KategoriaID = 2, NazwaKategorii = "Napoje", NazwaPlikuIkony = "Napoje.png", Opiskategorii = "Mniam piciu"},
                new Kategoria(){KategoriaID = 3, NazwaKategorii = "1 danie", NazwaPlikuIkony = "Alkohol.png", Opiskategorii = "Mniam d1"},

            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var jedzenie = new List<Jedzenie>
            {
                new Jedzenie() {JedzenieID = 1, KategoriaID = 1, Cena = 25, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 2, KategoriaID = 1, Cena = 26, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam2" },
                new Jedzenie() {JedzenieID = 3, KategoriaID = 1, Cena = 27, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam3" },
                new Jedzenie() {JedzenieID = 4, KategoriaID = 1, Cena = 28, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam4" },
                new Jedzenie() {JedzenieID = 5, KategoriaID = 1, Cena = 29, PlikObrazek = "Deser.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam5" },

                new Jedzenie() {JedzenieID = 6, KategoriaID = 2, Cena = 5, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam pepsi" },
                new Jedzenie() {JedzenieID = 7, KategoriaID = 2, Cena = 2, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam wpda" },

                new Jedzenie() {JedzenieID = 8, KategoriaID = 1, Cena = 29, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam5" },

                new Jedzenie() {JedzenieID = 9, KategoriaID = 2, Cena = 5, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam pepsi" },
                new Jedzenie() {JedzenieID = 10, KategoriaID = 2, Cena = 2, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam wpda" },


            };
            jedzenie.ForEach(k => context.Jedzenie.AddOrUpdate(k));
            context.SaveChanges();


        }
    }
}