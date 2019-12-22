using System;
using System.Collections.Generic;
using System.Text;

namespace Foodio.Models.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public DateTime DateCreated { get; set; }
        public Category Category { get; set; }

        public Recipe()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.UtcNow;
        }
    }
}
