namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CR_ChangeLocationToLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CardRequests", "CardLocation", c => c.Long(nullable: false));
            AlterColumn("dbo.CardRequests", "PinLocation", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CardRequests", "PinLocation", c => c.Int(nullable: false));
            AlterColumn("dbo.CardRequests", "CardLocation", c => c.Int(nullable: false));
        }
    }
}
