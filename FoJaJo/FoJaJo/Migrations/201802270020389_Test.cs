namespace FoJaJo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerInGame", "GameId", "dbo.Game");
            DropIndex("dbo.PlayerInGame", new[] { "GameId" });
            DropPrimaryKey("dbo.Game");
            DropPrimaryKey("dbo.PlayerInGame");
            AlterColumn("dbo.Game", "GameID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PlayerInGame", "GameId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Game", "GameID");
            AddPrimaryKey("dbo.PlayerInGame", new[] { "Username", "GameId" });
            CreateIndex("dbo.PlayerInGame", "GameId");
            AddForeignKey("dbo.PlayerInGame", "GameId", "dbo.Game", "GameID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerInGame", "GameId", "dbo.Game");
            DropIndex("dbo.PlayerInGame", new[] { "GameId" });
            DropPrimaryKey("dbo.PlayerInGame");
            DropPrimaryKey("dbo.Game");
            AlterColumn("dbo.PlayerInGame", "GameId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Game", "GameID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PlayerInGame", new[] { "Username", "GameId" });
            AddPrimaryKey("dbo.Game", "GameID");
            CreateIndex("dbo.PlayerInGame", "GameId");
            AddForeignKey("dbo.PlayerInGame", "GameId", "dbo.Game", "GameID");
        }
    }
}
