using burguerwebapp.Models;
using burguerwebapp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Controllers
{
    public class BurguerController : Controller
    {
        private readonly IBurguerRepository _burguerRepository;
        private readonly ICategoryRepository _categoryRepository;

       public BurguerController(IBurguerRepository burguerRepository, ICategoryRepository categoryRepository)
        {
            _burguerRepository = burguerRepository;
            _categoryRepository = categoryRepository;
         
        }
        
        //add action

        public ViewResult List()
        {
            BurguerListViewModel burguerListViewModel = new BurguerListViewModel();
            burguerListViewModel.Burguers = _burguerRepository.AllBurguers;

            burguerListViewModel.CurrentCategory = "Vegan";
            return View(burguerListViewModel);
        }

        public IActionResult Details (int id)
        {
            var burguer  = _burguerRepository.GetBurguerById(id);
            if (burguer == null) 
                return NotFound();
            return View(burguer);
        }
    }
}
