namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Name");
            DropColumn("dbo.Customers", "LikesDishId");
            DropColumn("dbo.Customers", "DislikesDishId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DislikesDishId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "LikesDishId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
