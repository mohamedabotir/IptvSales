namespace IptvSaless.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rebuild : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "usedTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Carts", "userId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carts", "userId", c => c.Int(nullable: false));
            DropColumn("dbo.Carts", "usedTime");
        }
    }
}
