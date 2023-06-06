namespace AdminPanel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Game_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.Game_Id);
            
            DropColumn("dbo.Games", "Genres");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Genres", c => c.String());
            DropForeignKey("dbo.Genres", "Game_Id", "dbo.Games");
            DropIndex("dbo.Genres", new[] { "Game_Id" });
            DropTable("dbo.Genres");
        }
    }
}
