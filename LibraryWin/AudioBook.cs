using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    internal class AudioBook : Book
    {
        private string narrator;

        private int length; //length in secs

        public AudioBook(string myName, int myIsbn, string myAuthor, double myPrice, string myGenre, int myQuantity, string myNarrator, int myLength)
        {
            name = myName;
            isbn = myIsbn;
            author = myAuthor;
            price = myPrice;
            genre = myGenre;
            quantity = myQuantity;
            narrator = myNarrator;
            length = myLength;
        }

        //display length in hrs and mins
        public void DisplayLength()
        {
            double mins = length / 60;
            double hrs = mins / 60;
            Console.WriteLine($"Length: {hrs} hrs or {mins} mins.");
        }

    }
}
