using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodio.Models.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Foodio.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeRepository recipeRepository;
        public RecipeController(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }

        public IActionResult Index()
        {
            return View(recipeRepository.GetAllRecipes());
        }
    }
}