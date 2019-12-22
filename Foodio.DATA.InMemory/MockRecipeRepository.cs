using Foodio.Models.Contracts;
using Foodio.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodio.DATA.InMemory
{
    public class MockRecipeRepository : IRecipeRepository
    {
        public IEnumerable<Recipe> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipeById(int recipeId)
        {
            throw new NotImplementedException();
        }
    }
}
