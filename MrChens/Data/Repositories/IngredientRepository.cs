using MrChens.Data.ORM.Context;
using MrChens.Data.Repositories.Converters;

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


        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Handlers.Models.Ingredient> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Handlers.Models.Ingredient Ingredient)
        {
            throw new NotImplementedException();
        }
    }
}