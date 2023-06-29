using BenchmarkDotNet.Running;
using Task2;

Storage<string> storage1 = new Storage<string>();

// Add
storage1.Add("Computer");
storage1.Add("PS4");
storage1.Add("Iphone 14");
storage1.Add("Laptop");

// Remove
storage1.Remove("Computer");
storage1.Remove("Iphone 14");

// Update
storage1.Update("PS4", "PS5");

// Print Storage Items
storage1.PrintItems();

// Benchmark
BenchmarkRunner.Run<TestStorage>();


Console.ReadKey();