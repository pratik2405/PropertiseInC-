﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public class Date
    {
        private int day, year;
        private string month;

        public void AcceptDate(int dd, string mm, int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }

        public string DisplayDate()
        {
            return $"Date is {day}/{month}/{year}";
        }
    }
}
