using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burguerwebapp.Models;
using burguerwebapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace burguerwebapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly IBurguerRepository _burguerRepo;

        public HomeController(IBurguerRepository burguerRepo)
        {
            _burguerRepo = burguerRepo;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BestSellers = _burguerRepo.IsBestSeller
            };

            return View(homeViewModel);
        }
    }
}
