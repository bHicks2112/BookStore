using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class CheckOutController : Controller
    {
        private ICheckOutRepository repo { get; set; }
        private Cart cart { get; set; }
        public CheckOutController (ICheckOutRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        [HttpGet]
        public IActionResult CheckOut()
        {
            return View(new CheckOut());
        }

        [HttpPost]
        public IActionResult CheckOut(CheckOut checkout)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                checkout.Lines = cart.Items.ToArray();
                repo.SaveCheckOut(checkout);
                cart.ClearCart();

                return RedirectToPage("/CheckOutCompleted");
            }
            else
            {
                return View();
            }
        }
    }
}
