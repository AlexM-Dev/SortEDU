using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_EDU {
    class Program {
        static void Main(string[] args) {
            int[] vals = new int[] { 1, 10, 7, 2, 5, 8 };

            Console.WriteLine(string.Join(", ", vals));

            Stopwatch timer = new Stopwatch();
            timer.Start();

            Algorithms.InsertionSort_2(ref vals);

            timer.Stop();

            Console.WriteLine(string.Join(", ", vals));
            Console.WriteLine($"Took {timer.ElapsedMilliseconds} milliseconds.");

            Console.ReadKey();
        }
    }
}
