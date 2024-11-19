using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Overriding
{
    public class SalesManager:Employee
    {
        private double bonus, comm;
        // base keyword will call the base class constructor
        public SalesManager(string nm, double basic, Date date, double bonus, double comm) : base(nm, basic, date)
        {
            this.bonus = bonus;
            this.comm = comm;
        }

        // polymorphism - method overrding
        public override void CalculateSalary()
        {
            hra = basic * 0.30;
            da = basic * 0.25;
            pf = basic * 0.12;
            gross = (basic + hra + da + bonus + comm) - pf;
        }
        // ToString() - is used to represent object in string format
        public override string ToString() // overriding method from base class (object)
        {
            return $"Sales person details : id = {id}, name ={name}, gross ={gross}";
        }

    }
}
