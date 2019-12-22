using Foodio.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodio.Models.Contracts
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAllRecipes { get; }
        Recipe GetRecipeById(string recipeId);
    }
}
