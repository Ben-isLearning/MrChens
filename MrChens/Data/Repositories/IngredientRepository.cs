using MrChens.Data.ORM.Context;
using MrChens.Data.Repositories.Converters;
using System.Data.Entity.Migrations;

namespace MrChens.Data.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        //CRUD functionality goes here
        private readonly IMrChensContext _MrChensContext;

        public IngredientRepository(IMrChensContext mrChenscontext)
        {
            _MrChensContext = mrChenscontext;
        }

        public void Add(Handlers.Models.Ingredient ingredient)
        {
            var dbIngredient = IngredientConverter.Convert(ingredient);

            _MrChensContext.Ingredients.Add(dbIngredient);
            _MrChensContext.SaveChanges();
        }
        public Handlers.Models.Ingredient GetById(int Id)
        {
            //FirstOrDefault loops through all entries in Table - Finds First Entry that matches or the Default Entry that matches
            var dbIngredient = _MrChensContext.Ingredients.FirstOrDefault(x => x.IngredientId == Id);

            if (dbIngredient != null)
            {
                var ingredient = IngredientConverter.Convert(dbIngredient);

                return ingredient;
            }
            return new Handlers.Models.Ingredient();
        }

        public IEnumerable<Handlers.Models.Ingredient> GetAll()
        {
            var dbIngredientList = _MrChensContext.Ingredients.ToList();

            var ingredientList = new List<Handlers.Models.Ingredient>();

            foreach (var dbIngredient in dbIngredientList)
            {
                var ingredient = new Handlers.Models.Ingredient()
                {
                    IngredientId = dbIngredient.IngredientId,
                    Name = dbIngredient.Name,
                    Quantity = dbIngredient.Quantity,
                }; 

                ingredientList.Add(ingredient);
            }

            return ingredientList;
        }

        public void Delete(int id)
        {
            var ingredient = _MrChensContext.Ingredients.Single(c => c.IngredientId == id);
            _MrChensContext.Ingredients.Remove(ingredient);
            _MrChensContext.SaveChanges();
    
        }


        public void Update(Handlers.Models.Ingredient Ingredient)
        {
          var dbIngredient = IngredientConverter.Convert(Ingredient);
            _MrChensContext.Ingredients.AddOrUpdate(dbIngredient);
            _MrChensContext.SaveChanges();
        }
    }
}