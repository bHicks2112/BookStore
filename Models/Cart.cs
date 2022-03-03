using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public virtual void AddItem (Books book, int qty)
        {
            CartLineItem Line = Items
                .Where(b => b.Books.BookId == book.BookId)
                .FirstOrDefault();

            if (Line == null)
            {
                Items.Add(new CartLineItem
                {
                    Books = book,
                    Quantity = qty
                });
            }
            else
            {
                Line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Books book)
        {
            Items.RemoveAll(x => x.Books.BookId == book.BookId);
        }

        public virtual void ClearCart()
        {
            Items.Clear();
        }
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Books.Price);

            return sum;
        }
    }



    public class CartLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Books Books { get; set; }

        public int Quantity { get; set; }
    }
}
