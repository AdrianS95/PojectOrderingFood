namespace NVC_Food_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jedzenie",
                c => new
                    {
                        JedzenieID = c.Int(nullable: false, identity: true),
                        KategoriaID = c.Int(nullable: false),
                        NazwaJedzenia = c.String(nullable: false, maxLength: 100),
                        OpisJedzenia = c.String(nullable: false, maxLength: 500),
                        DataDodania = c.DateTime(nullable: false),
                        PlikObrazek = c.String(maxLength: 150),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DanieDnia = c.Boolean(nullable: false),
                        Widoczny = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JedzenieID)
                .ForeignKey("dbo.Kategoria", t => t.KategoriaID, cascadeDelete: true)
                .Index(t => t.KategoriaID);
            
            CreateTable(
                "dbo.Kategoria",
                c => new
                    {
                        KategoriaID = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(nullable: false, maxLength: 100),
                        Opiskategorii = c.String(nullable: false, maxLength: 100),
                        NazwaPlikuIkony = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaID);
            
            CreateTable(
                "dbo.PozycjaZamowienia",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowienieID = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        jedzenie_JedzenieID = c.Int(),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Jedzenie", t => t.jedzenie_JedzenieID)
                .ForeignKey("dbo.Zamowienie", t => t.ZamowienieID, cascadeDelete: true)
                .Index(t => t.ZamowienieID)
                .Index(t => t.jedzenie_JedzenieID);
            
            CreateTable(
                "dbo.Zamowienie",
                c => new
                    {
                        ZamowienieID = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 40),
                        Nazwisko = c.String(nullable: false, maxLength: 40),
                        Ulica = c.String(nullable: false, maxLength: 40),
                        Miasto = c.String(nullable: false, maxLength: 40),
                        KodPocztowy = c.String(nullable: false, maxLength: 40),
                        Telefon = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 40),
                        Uwagi = c.String(),
                        DataDowania = c.DateTime(nullable: false),
                        StanZamówienia = c.Int(nullable: false),
                        WartoscZamówienia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ZamowienieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowienia", "ZamowienieID", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowienia", "jedzenie_JedzenieID", "dbo.Jedzenie");
            DropForeignKey("dbo.Jedzenie", "KategoriaID", "dbo.Kategoria");
            DropIndex("dbo.PozycjaZamowienia", new[] { "jedzenie_JedzenieID" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "ZamowienieID" });
            DropIndex("dbo.Jedzenie", new[] { "KategoriaID" });
            DropTable("dbo.Zamowienie");
            DropTable("dbo.PozycjaZamowienia");
            DropTable("dbo.Kategoria");
            DropTable("dbo.Jedzenie");
        }
    }
}
