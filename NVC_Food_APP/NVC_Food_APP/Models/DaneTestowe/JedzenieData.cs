using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NVC_Food_APP.Models;


namespace NVC_Food_APP.Models.DaneTestowe
{
    public class JedzenieData : DropCreateDatabaseAlways<JedzenieDbContext>
    {
        protected override void Seed(JedzenieDbContext context)
        {
            SeedJedzenieData(context);
            base.Seed(context);
        }

        private void SeedJedzenieData(JedzenieDbContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaID = 1, NazwaKategorii = "Pizza", NazwaPlikuIkony = "Pizza.png", Opiskategorii = "Mniam Pizza"},
                new Kategoria(){KategoriaID = 2, NazwaKategorii = "Napoje", NazwaPlikuIkony = "Picie.png", Opiskategorii = "Mniam piciu"},
            };
            kategorie.ForEach(k => context.Kategorie.Add(k));
            context.SaveChanges();

            var jedzenie = new List<Jedzenie>
            {
                new Jedzenie() {JedzenieID = 1, KategoriaID = 1, Cena = 25, PlikObrazek = "pizza1.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam1" },
                new Jedzenie() {JedzenieID = 2, KategoriaID = 1, Cena = 26, PlikObrazek = "pizza2.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam2" },
                new Jedzenie() {JedzenieID = 3, KategoriaID = 1, Cena = 27, PlikObrazek = "pizza3.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam3" },
                new Jedzenie() {JedzenieID = 4, KategoriaID = 1, Cena = 28, PlikObrazek = "pizza4.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam4" },
                new Jedzenie() {JedzenieID = 5, KategoriaID = 1, Cena = 29, PlikObrazek = "pizza5.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam5" },

                new Jedzenie() {JedzenieID = 6, KategoriaID = 2, Cena = 5, PlikObrazek = "pepsi.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam pepsi" },
                new Jedzenie() {JedzenieID = 4, KategoriaID = 2, Cena = 2, PlikObrazek = "woda.png", DataDodania = DateTime.Now, DanieDnia = false, NazwaJedzenia = "pizza z mięsem", Widoczny = true, OpisJedzenia = "Mniam wpda" },



            };
            jedzenie.ForEach(k => context.Jedzenie.Add(k));
            context.SaveChanges();


        }
    }
}