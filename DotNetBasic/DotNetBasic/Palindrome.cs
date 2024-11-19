using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNetDemo
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            int num = 1221;
            int original = num;
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;

            }
            Console.WriteLine(original == reverse ? "palindrome" : "Not a palindrome");
        }
    }
}
//         num        original             rem      reverse       num
//          1221          1221              1           1         122
//          122                             2           12        12
//          12                              2           122       1
//          1                               1           1221      0
//                        1221                          1221