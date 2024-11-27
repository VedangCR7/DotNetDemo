using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Airplane : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Airplane is flying");

        }
    }
}
