namespace NVC_Food_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_Imie", c => c.String());
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_Nazwisko", c => c.String());
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_Adres", c => c.String());
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_Miasto", c => c.String());
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_KodPocztowy", c => c.String());
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_Email", c => c.String());
            AddColumn("dbo.AspNetUsers", "DaneUzytkownika_Telefon", c => c.String());
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_Imie");
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_Nazwisko");
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_Adres");
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_Miasto");
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_KodPocztowy");
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_Email");
            DropColumn("dbo.AspNetUsers", "daneUrzytkownika_Telefon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_Telefon", c => c.String());
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_Email", c => c.String());
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_KodPocztowy", c => c.String());
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_Miasto", c => c.String());
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_Adres", c => c.String());
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_Nazwisko", c => c.String());
            AddColumn("dbo.AspNetUsers", "daneUrzytkownika_Imie", c => c.String());
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_Telefon");
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_Email");
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_KodPocztowy");
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_Miasto");
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_Adres");
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_Nazwisko");
            DropColumn("dbo.AspNetUsers", "DaneUzytkownika_Imie");
        }
    }
}
