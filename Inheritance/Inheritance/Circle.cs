using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Circle : Shape
    {
        private double r, area, perimeter;
        public Circle(double r)
        {
            this.r = r;
            //this.area = area;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Area of Circle is {area = 3.14 * r * r}"); 
        }

        public override void CalculatePeriemter()
        {
            Console.WriteLine($"Perimeter of Ciricle is {perimeter = 2 * 3.14 * r}");
        }
    }
}
