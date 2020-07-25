namespace InOutStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserStatus", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserStatus", "User_Id");
            AddForeignKey("dbo.UserStatus", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStatus", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserStatus", new[] { "User_Id" });
            DropColumn("dbo.UserStatus", "User_Id");
        }
    }
}
