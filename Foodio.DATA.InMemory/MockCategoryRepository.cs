using Foodio.Models.Contracts;
using Foodio.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodio.DATA.InMemory
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
