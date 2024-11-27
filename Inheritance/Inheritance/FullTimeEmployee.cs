using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            int result = HoursWorked * 500;
            Console.WriteLine($"Salary of FTE is {result}");
        }
    }
}
