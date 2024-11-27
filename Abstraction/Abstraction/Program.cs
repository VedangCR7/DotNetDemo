using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 3, 4);
            r.CalculateArea();
            Console.WriteLine(r);
        }
    }
}
