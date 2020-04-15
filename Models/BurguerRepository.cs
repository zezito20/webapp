using burguerwebapp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Models
{
    public class BurguerRepository : IBurguerRepository
    {
        private readonly AppDbContext _appDbcontext;

        public BurguerRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }

        public IEnumerable<Burguer> AllBurguers
        {
            get
            {
                return _appDbcontext.Burguers.Include(c => c.Category);
            }
        }

        public IEnumerable<Burguer> IsBestSeller
        {
            get
            {
                return _appDbcontext.Burguers.Include(c => c.Category).Where(b => b.IsBestSeller);
            }
        }

        public Burguer GetBurguerById(int burguerId)
        {
            return _appDbcontext.Burguers.FirstOrDefault(b => b.BurguerId == burguerId);
        }
    }
}
