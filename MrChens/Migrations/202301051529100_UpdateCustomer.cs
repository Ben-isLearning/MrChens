namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            DropColumn("dbo.Customers", "Likes");
            DropColumn("dbo.Customers", "Dislikes");
            DropColumn("dbo.Customers", "GuestId");
            DropColumn("dbo.Customers", "Name");
            AddColumn("dbo.Customers", "CustomerId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "LikesDishId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "DislikesDishId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Dislikes", c => c.String());
            AddColumn("dbo.Customers", "Likes", c => c.String());
            AddColumn("dbo.Customers", "GuestId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Customers");
            DropColumn("dbo.Customers", "DislikesDishId");
            DropColumn("dbo.Customers", "LikesDishId");
            DropColumn("dbo.Customers", "CustomerId");
            AddPrimaryKey("dbo.Customers", "GuestId");
        }
    }
}
