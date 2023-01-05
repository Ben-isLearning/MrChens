namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserToIngredient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientId);
            
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            DropTable("dbo.Ingredients");
        }
    }
}
