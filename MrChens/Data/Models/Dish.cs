using System.ComponentModel.DataAnnotations;

namespace MrChens.Data.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }

    }
}
