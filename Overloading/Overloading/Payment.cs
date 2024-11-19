using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Payment
    {
        public static void PayBill(double amt)
        {
            Console.WriteLine("Bill amount " + amt);
        }
        public static void PayBill(double amt ,string mode)
        {
            if (mode != "cash")
            {
                double discount = amt * 0.15;
                double finalAmount = amt - discount;
                Console.WriteLine("Original bill " + amt);
                Console.WriteLine("Final Amount after discount" + finalAmount);
            }
            else
            {
                PayBill(amt);
            }
           
        }
    }
}
