using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_EDU {
    static class Program {
        static void Main(string[] args) {
            int[] vals = generateValues(50000);

            Console.WriteLine(string.Join(", ", vals));

            Stopwatch timer = new Stopwatch();
            timer.Start();

            //Sorting_Algorithms_EDU_VB.Algorithms.InsertionSort(ref vals);
            Sorting_Algorithms_EDU.Algorithms.InsertionSort(ref vals);

            timer.Stop();

            Console.WriteLine(string.Join(", ", vals));
            Console.WriteLine($"Took {timer.ElapsedMilliseconds} milliseconds.");

            Console.ReadKey();
        }

        static int[] generateValues(int length) {
            // Don't use this in a closed loop.
            // Only, of course, if you wish to use an existing
            // instance of random.
            int[] vals = new int[length];
            Random random = new Random();

            for (int i = 0; i < length - 1; i++) {
                vals[i] = random.Next(length);
            }

            return vals;
        }
    }
}
