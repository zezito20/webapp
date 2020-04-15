using burguerwebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.ViewModels
{
    public class BurguerListViewModel
    {

        public IEnumerable<Burguer> Burguers { get; set; }
        public string CurrentCategory { get; set; }
    }
}
