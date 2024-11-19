using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNetDemo
{
    internal class CalculationMain
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
           int r1= c1.Sub(5, 3, 2);
            float r2=c1.Sub(3, 3.2f);
            Console.WriteLine(r1 + " " + r2);

            int m1= c1.Mul(5, 3, 2);
            double m2 = c1.Mul(3, 4.5);
            double m3 = c1.Mul(4.5, 3);
            Console.WriteLine($"{m1} {m2} {m3}");

        }
    }
}
