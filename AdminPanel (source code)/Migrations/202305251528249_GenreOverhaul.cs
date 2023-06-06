namespace AdminPanel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreOverhaul : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            //DropColumn("dbo.Games_Genres", "GenreId");
            //RenameColumn(table: "dbo.Games_Genres", name: "Genre_Id", newName: "GenreId");
            //CreateIndex("dbo.Games_Genres", "GenreId");
            AddForeignKey("dbo.Games_Genres", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            //DropColumn("dbo.Games", "Genre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Genre_Id", c => c.Int());
            DropForeignKey("dbo.Games_Genres", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games_Genres", new[] { "GenreId" });
            RenameColumn(table: "dbo.Games_Genres", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbo.Games_Genres", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "Genre_Id");
            AddForeignKey("dbo.Games", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
