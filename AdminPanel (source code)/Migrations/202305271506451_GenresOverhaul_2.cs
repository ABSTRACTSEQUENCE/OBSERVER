namespace AdminPanel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenresOverhaul_2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games_Genres", "GameId", "dbo.Games");
            DropForeignKey("dbo.Games_Genres", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games_Genres", new[] { "GameId" });
            DropIndex("dbo.Games_Genres", new[] { "GenreId" });
            CreateTable(
                "dbo.GenreGames",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Game_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Game_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.Game_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Game_Id);
            
            DropTable("dbo.Games_Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Games_Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.GenreGames", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.GenreGames", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.GenreGames", new[] { "Game_Id" });
            DropIndex("dbo.GenreGames", new[] { "Genre_Id" });
            DropTable("dbo.GenreGames");
            CreateIndex("dbo.Games_Genres", "GenreId");
            CreateIndex("dbo.Games_Genres", "GameId");
            AddForeignKey("dbo.Games_Genres", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Games_Genres", "GameId", "dbo.Games", "Id", cascadeDelete: true);
        }
    }
}
