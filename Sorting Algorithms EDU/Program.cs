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
            string ln = new string('=', 10);
            for (int i = 0; i < 50; i++) {
                int[] select = Helpers.GenerateValues(50000);
                int[] insert = (int[])select.Clone();

                Console.WriteLine($"{ln} Generated values for {i} {ln}");

                long selection = 
                    timeMethod(() => SortingAlgorithms.SelectionSort(ref select));
                Console.WriteLine($"Selection sort took {selection}ms.");

                long insertion =
                    timeMethod(() => SortingAlgorithms.InsertionSort(ref insert));
                Console.WriteLine($"Insertion sort took {insertion}ms.");
            }

            Console.ReadKey();
        }

        static long timeMethod(Action a) {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            a.Invoke();

            timer.Stop();

            return timer.ElapsedMilliseconds;
        }
    }
}
