using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface ICheckOutRepository
    {
        IQueryable<CheckOut> CheckOut { get; }

        void SaveCheckOut(CheckOut CheckOut);
    }
}
