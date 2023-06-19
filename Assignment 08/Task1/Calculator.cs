using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Calculator
    {
        private static int a;
        private static int b;
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Nulze gayofa ar sheidzleba!");
            }
            return a / b;
        }

        public static double Pow(double a, int b)
        {
            if (b == 0)
            {
                return 1;
            }

            if (b == 1)
            {
                return a;
            }

            if (b < 0)
            {
                a = 1 / a;
                b = -b;
            }

            double result = 1;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    result *= a;
                }

                a *= a;
                b /= 2;
            }

            return result;
        }

        public static double Sqrt(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Ar unda iyos uarofiti ricxvi!");
            }

            if (a == 0 || a == 1)
            {
                return a;
            }

            double result = 1;
            double i = 0;
            while (true)
            {
                i++;
                result = (a / result + result) / 2;
                if (i == (int)a + 1)
                {
                    break;
                }
            }
            return result;
        }
    }
}
