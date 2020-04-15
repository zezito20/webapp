using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Models
{
    public class Burguer
    {
        public int BurguerId { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Price { get; set; }

        //use image on blob
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public bool IsBestSeller { get; set; }

        //want to have a category also.
        //so create category too
        public Category Category { get; set; }
    }
}

