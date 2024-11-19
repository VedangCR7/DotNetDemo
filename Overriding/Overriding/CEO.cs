using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class CEO : Employee
    {
        private double bonus;
        private string CompanyName;
        public CEO(string nm,string cn,double bonus, double bs, Date date) : base(nm, bs, date)
        {
            this.bonus = bonus;
            this.CompanyName = cn;
            
        }

        public override void CalculateSalary()
        {
            hra = basic * 0.30;
            da = basic * 0.25;
            pf = basic * 0.12;
            gross = (basic + hra + da + bonus ) - pf;

        }

        public override string ToString()
        {
            return $"CEO Details : ID={id}, Name={name}, Gross_sal={gross} Company Name={CompanyName} ";
        }
    }
}
