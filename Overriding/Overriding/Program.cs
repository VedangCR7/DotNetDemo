using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(01, "Nov");

            CEO c1 = new CEO("Alan","Jacob & Co",3000,80000,d1);
            c1.CalculateSalary();
            Console.WriteLine(c1);

            Employee em1 = new CEO("Alex", "Bacca Bucci", 8000, 85000, new Date(15, "Dec"));
            em1.CalculateSalary();
            Console.WriteLine(em1);

        }
    }
}
