using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Rectangle : Shape
    {
        private int l, b, h,area;

        public Rectangle(int lenght,int breadth,int heigth)
        {
            this.l=lenght;
            this.b=breadth; 
            this.h=heigth;

        }
        public override void CalculateArea()
        {
            area = l * b * h;
        }

        public override string ToString()
        {
            return $"Area of Rectangle is {area}";
        }
    }
}
