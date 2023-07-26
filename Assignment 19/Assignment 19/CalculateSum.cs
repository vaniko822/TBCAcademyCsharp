using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19
{
    public class CalculateSum
    {
        public static long CalculateSequentialSum(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            stopwatch.Stop();
            Console.WriteLine($"Sequential calculation took {stopwatch.ElapsedMilliseconds} ms");
            return sum;
        }
        public static void CalculatePartialSum(int start, int end, int threadIndex, int[] array, int[] partialSums)
        {
            int partialSum = 0;
            for (int i = start; i < end; i++)
            {
                partialSum += array[i];
            }

            partialSums[threadIndex-1] = partialSum;

        }
    }
}
