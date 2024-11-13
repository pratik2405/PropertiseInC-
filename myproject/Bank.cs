using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    //2.  Create a Bank class, assign balance in constructor, create deposit & withdraw method & display methods
    //Deposit will add amount in balance
    //Withdraw will remove the amount from balance.amount should be remove if its less than balance
    //Display will show balance

    public class Bank
    {
        // declare data members
        private int accno;
        private string name;
        private double bal;

        //create parametric constructor for accept values.
        public Bank(int accno, string name, double bal)
        {
            this.accno = accno;
            this.name = name;
            this.bal = bal;
        }

        //create a deposit method to add amt to the current balance.
        public void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Deposit amount" + amt);
            Console.WriteLine("Current balance = " + bal);
        }

        //create a withdeow method to  withdrow(-) amt from the current bank balance
        public void withdrow(int amt)
        {
            if(amt > bal)
            {
                Console.WriteLine("Amount is not sufficient to withdrow!"+amt);
            }
            else {
                bal = bal-amt;
                Console.WriteLine("Withdrow Successful="+ amt);
                Console.WriteLine("current bal=" + bal);
            }
        }

        //method to print data that take to custructor
        public string printdata()
        {
            return $"Acc no= {accno} / Name= {name} / Current bal = {bal}";
        }
    }
}
