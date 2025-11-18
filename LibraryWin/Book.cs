using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library
{
    internal class Book
    {
        protected string name;
        protected int isbn;
        protected string author;
        protected double price;
        protected string genre;
        protected int quantity;
        protected int pages;

        public Book()
        {

        }

        public Book(string myName, int myIsbn, string myAuthor, string myGenre)
        {
            name = myName;
            isbn = myIsbn;
            author = myAuthor;
            price = 12.99;
            genre = myGenre;
            quantity = 20;
        }

        public Book(string myName, int myIsbn, string myAuthor, double myPrice, string myGenre, int myQuantity, int myPages)
        {
            name = myName;
            isbn = myIsbn;
            author = myAuthor;
            price = myPrice;
            genre = myGenre;
            quantity = myQuantity;
            pages = myPages;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public void checkout()
        {
            if (quantity > 0)
            {
                quantity--;
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
        }

        public void changePrice(double newPrice)
        {
            price = newPrice;
        }

        public void disBookInfo()
        {
            Console.WriteLine($"Name: {name}\nISBN: {isbn}\nAuthor: {author}\nPrice: {price}\nGenre: {genre}\nQuantity: {quantity}");
        }
    }
}
