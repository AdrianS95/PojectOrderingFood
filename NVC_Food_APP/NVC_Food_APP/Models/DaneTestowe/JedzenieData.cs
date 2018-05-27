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
                new Kategoria(){KategoriaID = 2, NazwaKategorii = "Pierwsze dania", NazwaPlikuIkony = "P1.png", Opiskategorii = "Mniam P1"},
                new Kategoria(){KategoriaID = 3, NazwaKategorii = "Drugie dania", NazwaPlikuIkony = "P2.png", Opiskategorii = "Mniam P2"},
                new Kategoria(){KategoriaID = 4, NazwaKategorii = "Desery", NazwaPlikuIkony = "Desery.png", Opiskategorii = "Mniam Deser"},
                new Kategoria(){KategoriaID = 5, NazwaKategorii = "Napoje", NazwaPlikuIkony = "Napoje.png", Opiskategorii = "Mniam piciu"},
                new Kategoria(){KategoriaID = 6, NazwaKategorii = "Alkohole", NazwaPlikuIkony = "Alkohol.png", Opiskategorii = "Mniam mocne piciu"},

            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var jedzenie = new List<Jedzenie>
            {
                new Jedzenie() {JedzenieID = 1, KategoriaID = 1, Cena = 22, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem 30CM", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 2, KategoriaID = 1, Cena = 28, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem 40CM", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 3, KategoriaID = 1, Cena = 35, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "pizza z mięsem 50CM", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 4, KategoriaID = 1, Cena = 21, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z owocami 30CM", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 5, KategoriaID = 1, Cena = 25, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z owocami 40CM", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 6, KategoriaID = 1, Cena = 30, PlikObrazek = "Pizza.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z owocami 50CM", Widoczny = true, OpisJedzenia = "Mniam1" },

                new Jedzenie() {JedzenieID = 7, KategoriaID = 2, Cena = 8, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Rosół z makaronem ", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 8, KategoriaID = 2, Cena = 9, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Rosół z ryżem", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 9, KategoriaID = 2, Cena = 10, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "Żurek staropolski", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 10, KategoriaID = 2, Cena = 9, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Krem z pomidorów", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 11, KategoriaID = 2, Cena = 7, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Kalafiorowa", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 12, KategoriaID = 2, Cena = 8, PlikObrazek = "P1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Ogórkowa", Widoczny = true, OpisJedzenia = "Mniam1" },

                new Jedzenie() {JedzenieID = 13, KategoriaID = 3, Cena = 25, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "Kotlet schabowy", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 14, KategoriaID = 3, Cena = 24, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Kotlet drobiowy", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 15, KategoriaID = 3, Cena = 23, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Pierś z kurczaka na parze", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 16, KategoriaID = 3, Cena = 26, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "Kurczak piekielnie ostry", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 17, KategoriaID = 3, Cena = 25, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Wieprzowina piekielnie ostra", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 18, KategoriaID = 3, Cena = 24, PlikObrazek = "P2.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "Kurczak w 5 smakach", Widoczny = true, OpisJedzenia = "Mniam1" },

                new Jedzenie() {JedzenieID = 19, KategoriaID = 4, Cena = 8, PlikObrazek = "Desery.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Ciasto z gruszkami", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 20, KategoriaID = 4, Cena = 7, PlikObrazek = "Desery.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Tort 'Mocca'", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 21, KategoriaID = 4, Cena = 8, PlikObrazek = "Desery.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Malinowiec", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 22, KategoriaID = 4, Cena = 9, PlikObrazek = "Desery.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Ciasto WZ", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 23, KategoriaID = 4, Cena = 7, PlikObrazek = "Desery.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Kremówka truskawkowa", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 24, KategoriaID = 4, Cena = 9, PlikObrazek = "Desery.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Sernik", Widoczny = true, OpisJedzenia = "Mniam1" },

                new Jedzenie() {JedzenieID = 25, KategoriaID = 5, Cena = 5, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Pepsi 300ML", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 26, KategoriaID = 5, Cena = 5, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Mirinda 300ML", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 27, KategoriaID = 5, Cena = 3, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Woda", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 28, KategoriaID = 5, Cena = 6, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Cherbata z cytryną", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 29, KategoriaID = 5, Cena = 9, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = true, NazwaJedzenia = "Kawa z pianką", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 30, KategoriaID = 5, Cena = 6, PlikObrazek = "Napoje.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Mleko", Widoczny = true, OpisJedzenia = "Mniam1" },

                new Jedzenie() {JedzenieID = 31, KategoriaID = 6, Cena = 7, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Piwo Tyskie 500ML", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 32, KategoriaID = 6, Cena = 9, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Piwo Tyskie 750ML", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 33, KategoriaID = 6, Cena = 29, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Wódka Finlandia 500ML", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 34, KategoriaID = 6, Cena = 35, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Wódka Finlandia 7500ML", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 35, KategoriaID = 6, Cena = 15, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Drink kombinacja x", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 36, KategoriaID = 6, Cena = 12, PlikObrazek = "Alkohol.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "Drink kombinacja y", Widoczny = true, OpisJedzenia = "Mniam1" },




            };

            jedzenie.ForEach(k => context.Jedzenie.AddOrUpdate(k));
            context.SaveChanges();


        }
    }
}