namespace TDU.CMS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecif : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CardRequests", "Cif", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CardRequests", "Cif", c => c.String(maxLength: 9));
        }
    }
}
