namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardInfoes",
                c => new
                    {
                        CardNumber = c.String(nullable: false, maxLength: 128),
                        TypeID = c.Long(nullable: false),
                        AccountNumber = c.String(),
                        CardHolder = c.String(),
                    })
                .PrimaryKey(t => t.CardNumber)
                .ForeignKey("dbo.CardTypes", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.CardTypes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Bin = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardInfoes", "TypeID", "dbo.CardTypes");
            DropIndex("dbo.CardInfoes", new[] { "TypeID" });
            DropTable("dbo.CardTypes");
            DropTable("dbo.CardInfoes");
        }
    }
}
