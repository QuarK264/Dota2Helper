namespace Dota2Helper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteHeroDscr : DbMigration
    {
        public override void Up()
        {
            //dropcolumn("dbo.hero", "desc");
        }

        public override void Down()
        {
            //addcolumn("dbo.hero", "desc", c => c.string());
        }
    }
}
