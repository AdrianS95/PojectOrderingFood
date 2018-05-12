namespace PojectOrderingFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AplicationUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        TelephoneNumber = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        TypeConference = c.Int(nullable: false),
                        City = c.String(nullable: false),
                        PostCode = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreateOrder = c.DateTime(nullable: false),
                        IdKlient_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AplicationUsers", t => t.IdKlient_Id)
                .Index(t => t.IdKlient_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ImmageLink = c.String(),
                        Order_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "IdKlient_Id", "dbo.AplicationUsers");
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "IdKlient_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.AplicationUsers");
        }
    }
}
