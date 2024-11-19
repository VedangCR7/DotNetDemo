using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNetDemo
{
    //Overloading Eample
    public class Calculation
    {
        public int Sub(int a , int b)
        {
            return a - b;
        }

        public int Sub(int a, int b,int c)
        {
            return a - b;
        }

        public float Sub(int a, float b)
        {
            return a - b;
        }

        public float Sub(float b, int a)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Mul(int a, int b,int c)
        {
            return a * b;
        }
        public double Mul(int a, double b)
        {
            return a * b;
        }
        public double Mul(double b, int a)
        {
            return a * b;
        }
    }
}
