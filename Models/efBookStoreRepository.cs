using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class efBookStoreRepository : iBookStoreRepository
    {

        private BookstoreContext context { get; set; }

        public efBookStoreRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;
    }
}
