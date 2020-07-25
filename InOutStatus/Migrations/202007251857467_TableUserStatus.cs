namespace InOutStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableUserStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkStatus = c.String(),
                        Location = c.String(),
                        Comment = c.String(),
                        QuickSet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserStatus");
        }
    }
}
