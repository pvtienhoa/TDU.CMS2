namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyUser : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "DeptID");
            AddForeignKey("dbo.Users", "DeptID", "dbo.Departments", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "DeptID", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "DeptID" });
        }
    }
}
