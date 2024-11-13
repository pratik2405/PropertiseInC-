using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date dt = new Date();
            //dt.AcceptDate(24, "Oct", 2024);
            //Console.WriteLine(dt.DisplayDate()); 

            //Student st = new Student(1, "Pratik", 90, 80, 70);
            //st.findpercentage();
            //Console.WriteLine(st.display());

            //Bank bank1 = new Bank(10101, "Pratik", 5000);
            //Console.WriteLine(bank1.printdata());
            //bank1.deposit(5000);
            //bank1.withdrow(6000);

            //Product p1 = new Product(101, "laptop", 30000);
            //Console.WriteLine(p1.print());
            //p1.getdis();

            //Book b1 = new Book(101, "Enjoy", "John", 500);
            //Console.WriteLine(b1.display());


            // Property initializer syntax for Book1 class
            Console.WriteLine("Book1 Class Property initializer");
            Book1 b1 = new Book1();
            b1.Bid = 101;
            b1.Name = "Nature";
            b1.Price = 100;

            Console.WriteLine($"BID={b1.Bid}/ Name= {b1.Name} / Price={b1.Price}");

            // object initializer syntax for Book1 class

            Book1 b2 = new Book1() { Bid = 102, Name = "City", Price = 200 };

            Console.WriteLine($"BID={b2.Bid}/ Name= {b2.Name} / Price={b2.Price}");


            // Property initializer syntax for Bank1 class
            Console.WriteLine("Bank1 Class Property initializer");

            Bank1 bank= new Bank1();
            bank.Accno = 101010;
            bank.Name = "Pratik";
            bank.Bal = 50000;

            Console.WriteLine($"Accno={bank.Accno} / Name={bank.Name} / Balance={bank.Bal}");

            Bank1 bk=new Bank1() { Accno=202020,Name="Rahul",Bal=60000};

            Console.WriteLine($"Accno={bk.Accno} / Name={bk.Name} /  Bal={bk.Bal}");


            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Employee Class Property initializer");

            Employee e1=new Employee();
            e1.Eid = 1;
            e1.Ename = "Yash";
            e1.Sal = 50000;
            Console.WriteLine($"Eid={e1.Eid} / Name={e1.Ename} / Sal={e1.Sal}");


        }
    }
}
