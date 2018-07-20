using System;
using System.Collections.Generic;
using System.Linq;
// Sorting library.
using Sorting;
using static Sorting.Helpers;

namespace Sorting_Algorithms_EDU {
    static class Program {
        static void Main(string[] args) {
            string ln = new string('=', 10);
            for (int i = 0; i < 50; i++) {
                int[] select = GenerateValues(50000);
                int[] insert = (int[])select.Clone();
                int[] quick = (int[])insert.Clone();
                int[] orderBy = (int[])quick.Clone();

                Console.WriteLine($"{ln} Generated values for {i} {ln}");

                long ordersort =
                    TimeMethod(() => orderBy = orderBy.OrderBy(x => x).ToArray());
                Console.WriteLine($"OrderBy sort took {ordersort}ms.");

                long quicksort =
                    TimeMethod(() => SortingAlgorithms.Quicksort(ref quick));
                Console.WriteLine($"Quicksort took {quicksort}ms.");

                long insertion =
                    TimeMethod(() => SortingAlgorithms.InsertionSort(ref insert));
                Console.WriteLine($"Insertion sort took {insertion}ms.");

                long selection =
                    TimeMethod(() => SortingAlgorithms.SelectionSort(ref select));
                Console.WriteLine($"Selection sort took {selection}ms.");


            }
            
            Console.ReadKey();
        }
    }
}
