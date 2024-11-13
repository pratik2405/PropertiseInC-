using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public class Bank1
    {
        private int accno;
        private string name;
        private double bal;

        public int Accno
        {
            set { accno = value; }
            get { return accno; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Bal
        {
            set { bal = value; }
            get { return bal; }
        }
    }
}
