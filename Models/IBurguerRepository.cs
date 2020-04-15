using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Models
{
    public interface IBurguerRepository

    {
        IEnumerable<Burguer> AllBurguers { get;}
        IEnumerable<Burguer> IsBestSeller { get;}
        Burguer GetBurguerById(int burguerId);
    }
}
