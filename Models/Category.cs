using System.Collections.Generic;

namespace burguerwebapp.Models
{
    public class Category
    {
        //details from category 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Burguer> Burguers { get; set; }
    }
}