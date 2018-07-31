using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
// Sorting library.
using Sorting;
using static Sorting.Helpers;

namespace Sorting_Algorithms_EDU {
    static class Program {
        static void Main(string[] args) {
            List<string> headers = new List<string>() {
                "#", "Selection", "Insertion", "Bubble Sort", "Quicksort", "OrderBy"
            };
            var rows = new List<List<string>>();

            List<int> amount = new List<int>() {
                1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000,
                5000, 10000, 20000, 50000, 100000, 200000,
                500000, 1000000, 2000000, 5000000
            };

            Table.DrawTable(headers, rows, 15);
            for (int i = 0; i < amount.Count; i++) {
                List<string> e = new List<string>();

                int[] select = GenerateValues(amount[i] - 1);
                int[] insert = (int[])select.Clone();
                int[] bubble = (int[])insert.Clone();
                int[] quick = (int[])bubble.Clone();
                int[] orderBy = (int[])quick.Clone();

                long selection = TimeMethod(() => SortingAlgorithms.SelectionSort(ref select));
                long insertion = TimeMethod(() => SortingAlgorithms.InsertionSort(ref insert));
                long bubblesort = TimeMethod(() => SortingAlgorithms.BubbleSort(ref bubble));
                long quicksort = TimeMethod(() => SortingAlgorithms.Quicksort(ref quick));
                long ordersort = TimeMethod(() => orderBy = orderBy.OrderBy(x => x).ToArray());
                e.AddRange(new[] { $"{amount[i]} items",
                                   $"{selection}ms",
                                   $"{insertion}ms",
                                   $"{bubblesort}ms",
                                   $"{quicksort}ms",
                                   $"{ordersort}ms"});

                rows.Add(e);

                Console.SetCursorPosition(0, 0);
                Table.DrawTable(headers, rows, 15);
            }

            Console.ReadKey();
        }
    }
}
