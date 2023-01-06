using MrChens.Handlers.Models;

namespace MrChens.Data.Repositories
{
    public interface IIngredientRepository
    {
        public void Add(Ingredient Ingredient);
        public void Update(Ingredient Ingredient);
        public void Delete(int Id);
        public IEnumerable<Ingredient> GetAll();
        public Ingredient GetById(int Id);

    }
}
