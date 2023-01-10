namespace MrChens.Handlers.Models
{
    public class Ingredient
    {
        public Ingredient(int ingredientId, string name, int quantity)
        { 
            IngredientId= ingredientId;
            Name= name; 
            Quantity= quantity; 
        }

        public Ingredient()
        {
            
        }

        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set;  }


    }

}
