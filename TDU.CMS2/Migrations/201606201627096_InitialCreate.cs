namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardRequests",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CardNumber = c.String(maxLength: 30),
                        CardHolder = c.String(maxLength: 30),
                        Cif = c.String(maxLength: 9),
                        Type = c.Int(nullable: false),
                        RequestDate = c.DateTime(nullable: false),
                        CardLocation = c.Int(nullable: false),
                        PinLocation = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        EmployeeName = c.String(maxLength: 50),
                        Code = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CardRequests");
        }
    }
}
