using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Date
    {

        // declare data members
        private int day, year;
        private string month;
        // method for assign the value to the data member

        // constructor to assign the value
        public Date(int day, string month, int year = 2024) // default parameter
        {
            this.day = day; // we will write this keyword for data member
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"Date is : {day} / {month} /{year}";
        }

    }
}
