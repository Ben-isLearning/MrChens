namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDishes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredients", "Dish_DishId", "dbo.Dishes");
            DropIndex("dbo.Ingredients", new[] { "Dish_DishId" });
            DropColumn("dbo.Ingredients", "Dish_DishId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Dish_DishId", c => c.Int());
            CreateIndex("dbo.Ingredients", "Dish_DishId");
            AddForeignKey("dbo.Ingredients", "Dish_DishId", "dbo.Dishes", "DishId");
        }
    }
}
