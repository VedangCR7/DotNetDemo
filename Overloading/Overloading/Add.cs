using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Add
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a, int b,int c)
        {
            return a + b;
        }
        public double Addition(int a, double b)
        {
            return a + b;
        }
        public double Addition(double b, int a)
        {
            return a + b;
        }
    }
}
