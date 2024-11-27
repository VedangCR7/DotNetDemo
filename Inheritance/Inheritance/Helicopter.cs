using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Helicopter : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Helicopter is flying");
        }
    }
}
