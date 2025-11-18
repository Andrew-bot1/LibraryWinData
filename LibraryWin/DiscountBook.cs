using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class DiscountBook : Book
    {
        //discount in percentage
        private double discount;
        public DiscountBook(string myName, int myIsbn, string myAuthor, double myPrice, string myGenre, int myQuantity, double myDiscount)
        {
            name = myName;
            isbn = myIsbn;
            author = myAuthor;
            price = myPrice;
            genre = myGenre;
            quantity = myQuantity;
            discount = myDiscount;
        }

        //display new price
        private void DisplayNewPrice()
        {
            double newPrice = price - (price * (discount / 100));
            Console.WriteLine($"New Price: {newPrice}");
        }
    }
}
