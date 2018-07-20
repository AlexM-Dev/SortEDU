using System;
using System.Collections.Generic;

// Sorting library.
using Sorting;
using static Sorting.Helpers;

namespace Sorting_Algorithms_EDU {
    static class Program {
        static void Main(string[] args) {
            string ln = new string('=', 10);
            for (int i = 0; i < 50; i++) {
                int[] select = Helpers.GenerateValues(50000);
                int[] insert = (int[])select.Clone();
                int[] quick = (int[])select.Clone();

                Console.WriteLine($"{ln} Generated values for {i} {ln}");

                long selection =
                    TimeMethod(() => SortingAlgorithms.SelectionSort(ref select));
                Console.WriteLine($"Selection sort took {selection}ms.");

                long insertion =
                    TimeMethod(() => SortingAlgorithms.InsertionSort(ref insert));
                Console.WriteLine($"Insertion sort took {insertion}ms.");

                long quicksort =
                    TimeMethod(() => SortingAlgorithms.Quicksort(ref insert));
                Console.WriteLine($"Quicksort took {quicksort}ms.");
            }
            
            Console.ReadKey();
        }
    }
}
