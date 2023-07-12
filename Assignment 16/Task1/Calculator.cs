using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }

        public static void Pow(double a, double b)
        {
            Console.WriteLine(Math.Pow(a, b));
        }

        public static void Sqrt(double a)
        {
            Console.WriteLine(Math.Sqrt(a));
        }

    }
}
