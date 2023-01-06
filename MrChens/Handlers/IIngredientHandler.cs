using MrChens.Handlers.Models;

namespace MrChens.Handlers
{
    public interface IIngredientHandler
    {
        public void Add(Ingredient Ingredient);
        public Ingredient GetById(int id);
        public IEnumerable<Ingredient> GetAll();
        public void Delete(int id);
        public void Update(Ingredient Ingredient);
    }
}

