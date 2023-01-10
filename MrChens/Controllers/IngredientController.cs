using Microsoft.AspNetCore.Mvc;
using MrChens.Handlers;
using MrChens.Handlers.Models;


namespace MrChens.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly ILogger<IngredientController> _logger;

        private readonly IIngredientHandler _IngredientHandler;

        public IngredientController(ILogger<IngredientController> logger, IIngredientHandler ingredientHandler)
        {
            _logger = logger;
            _IngredientHandler = ingredientHandler;
        }

        [HttpPost]
        [Route("AddIngredient")]
        public string AddIngredient(Ingredient ingredient)
        {
            _IngredientHandler.Add(ingredient);
            return "Ingredient Added";
        }

        [HttpGet]
        [Route("GetIngredientById/{id}")]
        public Ingredient GetIngredientById(int id)
        {
            var result = _IngredientHandler.GetById(id);
            return result;
        }

        [HttpGet]
        [Route("GetIngredients")]
        public IEnumerable<Ingredient> GetAll()
        {
            var result = _IngredientHandler.GetAll();
            return result; 
        }

        [HttpDelete]
        [Route("DeleteIngredientById/{id}")]
        public string DeleteIngredient(int id)
        {
            _IngredientHandler.Delete(id);
            return "Ingredient Deleted";
        }

        [HttpPut]
        [Route("UpdateIngredient")]
        public string PutIngredient(Ingredient ingredient)
        { 
        _IngredientHandler.Update(ingredient);
            return "Ingredient Updated";
        }
    }
}
