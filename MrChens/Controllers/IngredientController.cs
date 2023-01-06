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

    }
}
