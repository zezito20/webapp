using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Models
{
    public class MockBurguerCategory : IBurguerRepository
    {

        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Burguer> AllBurguers =>
            new List<Burguer>
            {
                new Burguer{BurguerId = 1, Name = "Chicken Burguer", Price=12.95M, ImageUrl="https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/chickenburger.jpg", Description="Veggie Burger with sweet potatoes", Category = _categoryRepository.AllCategories.ToList()[0], IsBestSeller = true},
                new Burguer{BurguerId = 2, Name = "Beef Burguer", Price=13.95M, ImageUrl="https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/BaconBurgers-infogourmet.jpg", Description="Traditional Beef Burger", Category = _categoryRepository.AllCategories.ToList()[1], IsBestSeller = false},
                new Burguer{BurguerId = 3, Name = "Double Beef Burguer", Price=14.95M, ImageUrl="https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/dbeef.jpg", Description="Double Taste", Category = _categoryRepository.AllCategories.ToList()[1], IsBestSeller = false},
                new Burguer{BurguerId = 4, Name = "Beef and Backon Burguer", Price=14.95M, ImageUrl="https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/Impossible-Burger-600-x-400.jpg", Description="Added taste of bacon", Category = _categoryRepository.AllCategories.ToList()[1], IsBestSeller = true}
            };


        public IEnumerable<Burguer> IsBestSeller { get; }

        public Burguer GetBurguerById (int burguerId)
        {
            return AllBurguers.FirstOrDefault(p => p.BurguerId == burguerId);
        }
    }
}
