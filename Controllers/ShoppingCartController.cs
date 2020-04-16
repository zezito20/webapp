using burguerwebapp.Models;
using burguerwebapp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//https://docs.microsoft.com/en-us/aspnet/web-forms/overview/getting-started/getting-started-with-aspnet-45-web-forms/shopping-cart

namespace burguerwebapp.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IBurguerRepository _burguerRepo;
        private readonly ShoppingCart _shoppingCart;


        public ShoppingCartController(IBurguerRepository burguerRepo, ShoppingCart shoppingCart)
        {
            _burguerRepo = burguerRepo;
            _shoppingCart = shoppingCart;
        }


        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int burguerId)
        {
            var selectedBurguer = _burguerRepo.AllBurguers.FirstOrDefault(p => p.BurguerId == burguerId);

            if (selectedBurguer != null)
            {
                _shoppingCart.AddToCart(selectedBurguer, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int burguerId)
        {
            var selectedBurguer = _burguerRepo.AllBurguers.FirstOrDefault(p => p.BurguerId == burguerId);

            if (selectedBurguer != null)
            {
                _shoppingCart.RemoveFromCart(selectedBurguer);
            }
            return RedirectToAction("Index");
        }
    }
}
