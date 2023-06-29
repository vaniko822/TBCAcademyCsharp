using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TestIntInterface
    {
        Interface<int> intInterface = new IntInterface();

        [Benchmark]
        public void Add()
        {
            var add = intInterface.Add(4, 5);
            Console.WriteLine(add);
        }

        [Benchmark]
        public void Subtract()
        {
            var subtract = intInterface.Subtract(10, 8);
            Console.WriteLine(subtract);
        }

        [Benchmark]
        public void Multiply()
        {
            var multiply = intInterface.Multiply(8, 8);
            Console.WriteLine(multiply);
        }
    }
}
