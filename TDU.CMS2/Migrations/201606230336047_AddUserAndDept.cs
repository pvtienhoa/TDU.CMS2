namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAndDept : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        EmployeeName = c.String(nullable: false, maxLength: 100),
                        TellerID = c.String(nullable: false, maxLength: 10),
                        DeptID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Departments");
        }
    }
}
