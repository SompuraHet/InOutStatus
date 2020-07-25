namespace InOutStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserStatus", "UpdatedAt", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserStatus", "UpdatedAt");
        }
    }
}
