using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TestDoubleInterface
    {
        Interface<double> doubleInterface = new DoubleInterface();

        [Benchmark]
        public void Add()
        {
            var add = doubleInterface.Add(10.4, 5.5);
            Console.WriteLine(add);
        }

        [Benchmark]
        public void Subtract()
        {
            var subtract = doubleInterface.Subtract(30.9, 20.1);
            Console.WriteLine(subtract);
        }

        [Benchmark]
        public void Multiply()
        {
            var multiply = doubleInterface.Multiply(8.8, 10.2);
            Console.WriteLine(multiply);
        }
    }
}

