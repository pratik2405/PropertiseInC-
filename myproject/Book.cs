using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    //4. Create Book class, add bid, name,price, author. Accept the details & display using constructor

    public class Book
    {
        private int bid;
        private string name,author;
        private double price;

        public Book(int bid,string name,string author,double price) {
            this.bid = bid;
            this.name = name;
            this.author = author;
            this.price = price;

            Console.WriteLine(display());
        }

        public string display()
        {
            return $"Bid={bid} / Name={name} / Author Name={author} / Price={price}";
        }
    }
}
