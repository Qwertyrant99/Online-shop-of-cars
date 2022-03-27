using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Data.Intefaces;
using SklepInternetowy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "Twój koszyk jest pusty!");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            
            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Zamówienie zostało złożone";
            return View();
        }
    }
}
