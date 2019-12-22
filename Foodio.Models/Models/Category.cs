using System;
using System.Collections.Generic;

namespace Foodio.Models.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Recipe> Recipes { get; set; }

        public Category()
        {
            CategoryId = Guid.NewGuid().ToString();
        }
    }
}