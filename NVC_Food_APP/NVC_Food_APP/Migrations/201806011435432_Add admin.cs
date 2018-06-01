namespace NVC_Food_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addadmin : DbMigration
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
                        JedzenieId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Jedzenie", t => t.JedzenieId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienie", t => t.ZamowienieID, cascadeDelete: true)
                .Index(t => t.ZamowienieID)
                .Index(t => t.JedzenieId);
            
            CreateTable(
                "dbo.Zamowienie",
                c => new
                    {
                        ZamowienieID = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Imie = c.String(nullable: false, maxLength: 40),
                        Nazwisko = c.String(nullable: false, maxLength: 40),
                        Adres = c.String(nullable: false, maxLength: 40),
                        Miasto = c.String(nullable: false, maxLength: 40),
                        KodPocztowy = c.String(nullable: false, maxLength: 40),
                        Telefon = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 40),
                        Uwagi = c.String(),
                        DataDowania = c.DateTime(nullable: false),
                        StanZamówienia = c.Int(nullable: false),
                        WartoscZamówienia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ZamowienieID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DaneUzytkownika_Imie = c.String(),
                        DaneUzytkownika_Nazwisko = c.String(),
                        DaneUzytkownika_Adres = c.String(),
                        DaneUzytkownika_Miasto = c.String(),
                        DaneUzytkownika_KodPocztowy = c.String(),
                        DaneUzytkownika_Email = c.String(),
                        DaneUzytkownika_Telefon = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Zamowienie", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.PozycjaZamowienia", "ZamowienieID", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowienia", "JedzenieId", "dbo.Jedzenie");
            DropForeignKey("dbo.Jedzenie", "KategoriaID", "dbo.Kategoria");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Zamowienie", new[] { "UserId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "JedzenieId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "ZamowienieID" });
            DropIndex("dbo.Jedzenie", new[] { "KategoriaID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Zamowienie");
            DropTable("dbo.PozycjaZamowienia");
            DropTable("dbo.Kategoria");
            DropTable("dbo.Jedzenie");
        }
    }
}
