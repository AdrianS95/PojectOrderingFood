using Microsoft.AspNet.Identity.EntityFramework;
using NVC_Food_APP.Models.DaneTestowe;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using static NVC_Food_APP.Models.IdentityModels;

namespace NVC_Food_APP.Models
{
    public class JedzenieDbContext : IdentityDbContext<ApplicationUser>
    {
        public JedzenieDbContext() : base("APP_Foof_DataBase")
        {

        }
        static JedzenieDbContext()
        {
            Database.SetInitializer<JedzenieDbContext>(new JedzenieData());
        }

        public static JedzenieDbContext Create()
        {
            return new JedzenieDbContext();
        }

        public DbSet<Jedzenie> Jedzenie { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjaZamowienia { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}