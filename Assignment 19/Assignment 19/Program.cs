// Create array and fill 
using Assignment_19;
using System.Diagnostics;

int[] array = new int[10000000];

Random rand = new Random();

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next()%100;
}

// Calculate Sequential Sum
var sequentialSum = CalculateSum.CalculateSequentialSum(array);
Console.WriteLine($"Sequential Sum - {sequentialSum}");

// Calculate Paralel Sum
int numOfThreads = 4;
int[] partialSums;

partialSums = new int[numOfThreads];
Thread[] threads = new Thread[numOfThreads];

int chunkSize = array.Length / numOfThreads;

Stopwatch stopwatch = Stopwatch.StartNew();

for (int i = 0; i < numOfThreads; i++)
{
    int start = i * chunkSize;
    int end = (i == numOfThreads - 1) ? array.Length : (i + 1) * chunkSize;
    threads[i] = new Thread(() => CalculateSum.CalculatePartialSum(start, end, i, array, partialSums));
    threads[i].Start();
}

foreach (Thread thread in threads)
{
    thread.Join();
}

int CalculateParallelSum = 0;
foreach (int partialSum in partialSums)
{
    CalculateParallelSum += partialSum;
}
stopwatch.Stop();

Console.WriteLine($"Parallel Sum - {CalculateParallelSum}");
Console.WriteLine($"Paralel calculation took {stopwatch.ElapsedMilliseconds} ms");