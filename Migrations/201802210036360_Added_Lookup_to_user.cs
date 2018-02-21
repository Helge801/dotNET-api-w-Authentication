namespace WebAPIAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Lookup_to_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Lookup", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Lookup");
        }
    }
}
