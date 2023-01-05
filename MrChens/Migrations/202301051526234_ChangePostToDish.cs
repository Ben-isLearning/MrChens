namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePostToDish : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        DishId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DishId);
            
            AddColumn("dbo.Ingredients", "Dish_DishId", c => c.Int());
            CreateIndex("dbo.Ingredients", "Dish_DishId");
            AddForeignKey("dbo.Ingredients", "Dish_DishId", "dbo.Dishes", "DishId");
            DropTable("dbo.Posts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId);
            
            DropForeignKey("dbo.Ingredients", "Dish_DishId", "dbo.Dishes");
            DropIndex("dbo.Ingredients", new[] { "Dish_DishId" });
            DropColumn("dbo.Ingredients", "Dish_DishId");
            DropTable("dbo.Dishes");
        }
    }
}
