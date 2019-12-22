using Foodio.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodio.Models.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
