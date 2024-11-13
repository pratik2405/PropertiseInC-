using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    //3. Create Product class, add code, name, price . Accept product details,
    //if price >1000 give 10 % discount on product . & display discounted price.

    public class Product
    {
        private int code;
        private string name;
        private double price,dis;

        public Product(int code, string name, double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

       public void  getdis()
        {
            if (price > 1000)
            {
                dis = price * 0.10;
                Console.WriteLine("Discounted amount is = " + dis);
            }
            else {
                dis = price * 0.05;
                Console.WriteLine("Discounted amount is = " + dis);
            }

        }

        public string print()
        {
            return $"Code={code}/ Name={name} / Origanl Price={price}";
        }
    }
}
