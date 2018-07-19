using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace Sorting_Algorithms_EDU {
    static class Program {
        static void Main(string[] args) {
            int[] vals = Helpers.GenerateValues(50000);

            Console.WriteLine(string.Join(", ", vals));

            Stopwatch timer = new Stopwatch();
            timer.Start();

            SortingAlgorithms.InsertionSort(ref vals);

            timer.Stop();

            Console.WriteLine(string.Join(", ", vals));
            Console.WriteLine($"Took {timer.ElapsedMilliseconds} milliseconds.");

            Console.ReadKey();
        }
    }
}
