namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCardRequest_AddForeinKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CardRequests", "DevideValue", c => c.Long(nullable: false));
            CreateIndex("dbo.CardRequests", "CardLocation");
            CreateIndex("dbo.CardRequests", "PinLocation");
            CreateIndex("dbo.CardRequests", "DevideValue");
            AddForeignKey("dbo.CardRequests", "CardLocation", "dbo.Departments", "ID");
            AddForeignKey("dbo.CardRequests", "DevideValue", "dbo.Departments", "ID");
            AddForeignKey("dbo.CardRequests", "PinLocation", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardRequests", "PinLocation", "dbo.Departments");
            DropForeignKey("dbo.CardRequests", "DevideValue", "dbo.Departments");
            DropForeignKey("dbo.CardRequests", "CardLocation", "dbo.Departments");
            DropIndex("dbo.CardRequests", new[] { "DevideValue" });
            DropIndex("dbo.CardRequests", new[] { "PinLocation" });
            DropIndex("dbo.CardRequests", new[] { "CardLocation" });
            DropColumn("dbo.CardRequests", "DevideValue");
        }
    }
}
