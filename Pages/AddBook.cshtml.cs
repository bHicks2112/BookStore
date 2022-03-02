using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Infrastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class AddBookModel : PageModel
    {
        private iBookStoreRepository repo { get; set; }
        public AddBookModel (iBookStoreRepository temp)
        {
            repo = temp;
        }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult Onpost(int bookid, string returnUrl)
        {

            Books b = repo.Books.FirstOrDefault(x => x.BookId == bookid);

            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            cart.AddItem(b, 1);

            HttpContext.Session.SetJson("cart", cart);

            return RedirectToPage(new { ReturnUrl = returnUrl });

        }
    }
}
