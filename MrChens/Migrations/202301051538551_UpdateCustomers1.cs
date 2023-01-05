namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
            AddColumn("dbo.Customers", "LikesDishId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "DislikesDishId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DislikesDishId");
            DropColumn("dbo.Customers", "LikesDishId");
            DropColumn("dbo.Customers", "Name");
        }
    }
}
