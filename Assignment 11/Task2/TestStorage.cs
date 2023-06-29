using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TestStorage
    {
        Storage<string> storage1 = new Storage<string>();

        [Benchmark]
        public void Add()
        {
            storage1.Add("Computer");
        }

        [Benchmark]
        public void Remove()
        {
            storage1.Remove("Computer");
            storage1.Remove("Iphone 14");
        }

        [Benchmark]
        public void Update()
        {
            storage1.Update("PS4", "PS5");
        }

        [Benchmark]
        public void PrintItems()
        {
            storage1.PrintItems();
        }
    }
}
