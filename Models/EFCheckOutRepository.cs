using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class EFCheckOutRepository : ICheckOutRepository
    {
        private BookstoreContext context;
        public EFCheckOutRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<CheckOut> CheckOut => context.CheckOut.Include(x => x.Lines).ThenInclude(x => x.Books);
        public void SaveCheckOut(CheckOut CheckOut)
        {
            context.AttachRange(CheckOut.Lines.Select(x => x.Books));

            if(CheckOut.CheckOutId == 0)
            {
                context.CheckOut.Add(CheckOut);
            }

            context.SaveChanges();
        }

    }
}
