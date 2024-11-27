using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SpaceCraft : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Spacecraft flying");
        }
    }
}
