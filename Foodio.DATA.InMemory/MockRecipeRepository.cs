using Foodio.Models.Contracts;
using Foodio.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foodio.DATA.InMemory
{
    public class MockRecipeRepository : IRecipeRepository
    {
        
        public IEnumerable<Recipe> GetAllRecipes => 
            new List<Recipe>
            {
                new Recipe {Name = "Pizza dough", Description = "Easy pizza dough in an hour and a half"},
                new Recipe {Name = "parfait", Description = "Yogurt parfait for breakfast"},
                new Recipe {Name = "Fied chicken", Description = "Deep fried Suday chicken"}

            };
       

        public Recipe GetRecipeById(string recipeId)
        {
            return GetAllRecipes.FirstOrDefault(r => r.Id == recipeId);
        }
    }
}
