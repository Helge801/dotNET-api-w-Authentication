namespace WebAPIAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removed_lookup : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "Lookup");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Lookup", c => c.Int(nullable: false));
        }
    }
}
