namespace Dota2Helper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(nullable: false),
                        PoolNumber = c.Byte(nullable: false),
                        BlockBKB = c.Boolean(nullable: false),
                        BlockLS = c.Boolean(nullable: false),
                        CommentBKB = c.String(),
                        CommentLS = c.String(),
                        ImageLink = c.String(),
                        HeroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hero", t => t.HeroId, cascadeDelete: true)
                .Index(t => t.HeroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skill", "HeroId", "dbo.Hero");
            DropIndex("dbo.Skill", new[] { "HeroId" });
            DropTable("dbo.Skill");
            DropTable("dbo.Hero");
        }
    }
}
