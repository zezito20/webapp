using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                 new Category{CategoryId = 1, CategoryName = "Vegetarian", Description = "Meat Free"},
                new Category{CategoryId = 2, CategoryName = "Meaty", Description = "Meat all the way"}
            };
        
    }
}
