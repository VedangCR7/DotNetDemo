using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Triangle : Shape
    {
        private double a, b, c ,area,perimeter;
        public Triangle(double sa,double sb,double sc) {
        this.a = sa;
        this.b = sb;
        this.c = sc;
        }
        public override void CalculateArea()
        {
            double area=(a+b+c)/2;
            Console.WriteLine($"Area of Triangle is {area}");
        }

        public override void CalculatePeriemter()
        {
            Console.WriteLine($"PErimeter of Triangle is {perimeter = a + b + c}");
        }
    }
}
