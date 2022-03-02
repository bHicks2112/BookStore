using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class CategoriesViewComponent : ViewComponent 
    {
        private iBookStoreRepository repo { get; set; }

        public CategoriesViewComponent (iBookStoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["bookCategory"];

            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
