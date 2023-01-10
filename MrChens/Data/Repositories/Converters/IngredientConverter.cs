namespace MrChens.Data.Repositories.Converters
{
    public class IngredientConverter
    {
        public static Data.Models.Ingredient Convert(Handlers.Models.Ingredient ingredient)
        {
            return new Models.Ingredient()
            {
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name,
                Quantity = ingredient.Quantity,
            }; 
        }

        public static Handlers.Models.Ingredient Convet(Data.Models.Ingredient ingredient)
        {
            return new Handlers.Models.Ingredient()
            {
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name,
                Quantity = ingredient.Quantity,
            };
        }
    }
}
