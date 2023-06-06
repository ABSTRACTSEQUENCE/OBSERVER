namespace AdminPanel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wtf : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comments", name: "Users_Id", newName: "User_Id");
            RenameIndex(table: "dbo.Comments", name: "IX_Users_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Comments", name: "IX_User_Id", newName: "IX_Users_Id");
            RenameColumn(table: "dbo.Comments", name: "User_Id", newName: "Users_Id");
        }
    }
}
