namespace Dota2Helper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviveSite : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hero", "Desc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hero", "Desc", c => c.String());
        }
    }
}
