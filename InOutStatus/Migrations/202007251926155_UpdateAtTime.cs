namespace InOutStatus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAtTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserStatus", "UpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserStatus", "UpdatedAt", c => c.String());
        }
    }
}
