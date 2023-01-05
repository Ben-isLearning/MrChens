namespace MrChens.Handlers.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Ingredient> Ingredients { get; set; }

    }
}
