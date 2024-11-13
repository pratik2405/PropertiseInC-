using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public  class Employee
    {
        private int eid;
        private string ename;
        private double sal;

        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public string Ename
        {
            set { ename = value; }
            get { return ename; }
        }
        public double Sal
        {
            set { sal = value; }
            get { return sal; }
        }
    }
}
