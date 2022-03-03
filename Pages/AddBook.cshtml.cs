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
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public AddBookModel (iBookStoreRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult Onpost(int bookid, string returnUrl)
        {

            Books b = repo.Books.FirstOrDefault(x => x.BookId == bookid);

            cart.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });

        }

        public IActionResult OnPostRemove (int bookId, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Books.BookId == bookId).Books);

            return RedirectToPage (new { ReturnUrl = returnUrl });
        }
    }
}
