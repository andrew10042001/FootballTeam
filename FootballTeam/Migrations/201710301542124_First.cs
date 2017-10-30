namespace FootballTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Humen",
                c => new
                    {
                        HumanId = c.Int(nullable: false, identity: true),
                        IdOfClub = c.Int(nullable: false),
                        IdOfRole = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HumanId)
                .ForeignKey("dbo.Roles", t => t.IdOfRole, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.IdOfClub, cascadeDelete: true)
                .Index(t => t.IdOfClub)
                .Index(t => t.IdOfRole);
            
            CreateTable(
                "dbo.HumanInfoes",
                c => new
                    {
                        HumanId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Position = c.String(),
                        Efficiency = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HumanId)
                .ForeignKey("dbo.Humen", t => t.HumanId)
                .Index(t => t.HumanId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        IdOfRole = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdOfRole);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        IdOfClub = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdOfClub);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Humen", "IdOfClub", "dbo.Teams");
            DropForeignKey("dbo.Humen", "IdOfRole", "dbo.Roles");
            DropForeignKey("dbo.HumanInfoes", "HumanId", "dbo.Humen");
            DropIndex("dbo.HumanInfoes", new[] { "HumanId" });
            DropIndex("dbo.Humen", new[] { "IdOfRole" });
            DropIndex("dbo.Humen", new[] { "IdOfClub" });
            DropTable("dbo.Teams");
            DropTable("dbo.Roles");
            DropTable("dbo.HumanInfoes");
            DropTable("dbo.Humen");
        }
    }
}
