using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PartTimeEmployee :Employee
    {
        public override void CalculateSalary()
        {
            double result = HoursWorked * 200;
            Console.WriteLine($"Sal of PTE is {result}");
        }
    }
}
