using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double basic, hra, da, pf, gross;
        private static int count;
        // containment
        private Date date;
        public Employee(string nm, double bs, Date date)
        {
            count++;
            id = count;
            name = nm;
            basic = bs;
            this.date = date;
        }
        // calculate emp salary
        public virtual void CalculateSalary()
        {
            hra = basic * 0.40; // 40% of basic salary
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        // display emp details
        public override string ToString()
        {
            return $"Id = {id} , Name {name}, Gross salary ={gross},Joining Date ={date.ToString()}";
        }

        // static method

        public static int EmpCount()
        {
            return count;
        }

    }
}
