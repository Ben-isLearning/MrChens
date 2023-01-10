﻿using MrChens.Data.Repositories;
using MrChens.Handlers.Models;

namespace MrChens.Handlers
{
    public class IngredientHandler : IIngredientHandler
    {
        private readonly IIngredientRepository _IngredientRepository;

        public IngredientHandler(IIngredientRepository ingredientRepository)
        {
            _IngredientRepository = ingredientRepository;
        }

        public void Add(Ingredient ingredient)
        {
            _IngredientRepository.Add(ingredient);
        }

        public Ingredient GetById(int id)
        {
            var result = _IngredientRepository.GetById(id);
            return result;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Ingredient Ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
