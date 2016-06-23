namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyChangeLog_keyvaluetostringtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ChangeLogs", "PrimaryKeyValue", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ChangeLogs", "PrimaryKeyValue", c => c.Long(nullable: false));
        }
    }
}
