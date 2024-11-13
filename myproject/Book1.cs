using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public class Book1
    {
        private int bid;
        private string name;
        private double price;

        // method for assign the value to the data member

        // properties for each data member

        public int Bid
        {
            set { bid = value; }
            get { return bid; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
