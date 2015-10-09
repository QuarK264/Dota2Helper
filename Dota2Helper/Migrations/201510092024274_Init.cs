namespace Dota2Helper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Heroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(),
                        PoolNumber = c.Byte(nullable: false),
                        BlockBKB = c.Boolean(nullable: false),
                        BlockLS = c.Boolean(nullable: false),
                        CommentBKB = c.String(),
                        CommentLS = c.String(),
                        ImageLink = c.String(),
                        HeroId = c.Int(nullable: false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Heroes", t => t.HeroId, cascadeDelete: true)
                .Index(t => t.HeroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "HeroId", "dbo.Heroes");
            DropIndex("dbo.Skills", new[] { "HeroId" });
            DropTable("dbo.Skills");
            DropTable("dbo.Heroes");
        }
    }
}
