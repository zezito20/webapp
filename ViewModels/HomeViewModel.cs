﻿using burguerwebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Burguer> BestSellers { get; set; }
    }
}
