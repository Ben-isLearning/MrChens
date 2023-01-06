using MrChens.Data.ORM.Context;
using MrChens.Handlers.Models;

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
        public void Add(Ingredient Ingredient)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ingredient GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Ingredient Ingredient)
        {
            throw new NotImplementedException();
        }
    }
}