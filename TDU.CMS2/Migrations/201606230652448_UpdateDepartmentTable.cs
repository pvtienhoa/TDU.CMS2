namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDepartmentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "ShortName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Departments", "Code", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Code");
            DropColumn("dbo.Departments", "ShortName");
        }
    }
}
