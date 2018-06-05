namespace NVC_Food_APP.Migrations
{
    using NVC_Food_APP.Models.DaneTestowe;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<NVC_Food_APP.Models.JedzenieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NVC_Food_APP.Models.JedzenieDbContext";
        }

        protected override void Seed(NVC_Food_APP.Models.JedzenieDbContext context)
        {
            
            JedzenieData.SeedJedzenieData(context);
            JedzenieData.SeedUzytkownicy(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
