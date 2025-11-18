using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    internal class Illustrated : Book
    {
        private string Illustrator;
        private int illustrationPages;

        public Illustrated(string myName, int myIsbn, string myAuthor, double myPrice, string myGenre, int myQuantity, int myPages, string myIllustrator, int myIllustrationPages)
        {
            name = myName;
            isbn = myIsbn;
            author = myAuthor;
            price = myPrice;
            genre = myGenre;
            quantity = myQuantity;
            pages = myPages;
            Illustrator = myIllustrator;
            illustrationPages = myIllustrationPages;
        }

        //display percent of pages that are illustrations
        public void DisplayIllustrationPercent()
        {
            double percent = (illustrationPages / pages) * 100;
            Console.WriteLine($"{percent}% of the pages have illustrations.");
        }
    }
}
