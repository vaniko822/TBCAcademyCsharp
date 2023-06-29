using BenchmarkDotNet.Running;
using Task1;

Interface<int> intInterface = new IntInterface();

var add = intInterface.Add(4, 5);
Console.WriteLine(add);

var subtract = intInterface.Subtract(10, 8);
Console.WriteLine(subtract);

var multiply = intInterface.Multiply(8, 8);
Console.WriteLine(multiply);

Interface<double> DoubleInterface = new DoubleInterface();

var add2 = DoubleInterface.Add(10.4, 5.5);
Console.WriteLine(add2);

var subtract2 = DoubleInterface.Subtract(30.9, 20.1);
Console.WriteLine(subtract2);

var multiply2 = DoubleInterface.Multiply(8.8, 10.2);
Console.WriteLine(multiply2);

/* Benchmarks */

//BenchmarkRunner.Run<TestIntInterface>();

//BenchmarkRunner.Run<TestDoubleInterface>();



Console.ReadKey();