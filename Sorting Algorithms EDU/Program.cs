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

            drawTable(headers, rows, 15);
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
                drawTable(headers, rows, 15);
            }

            Console.ReadKey();
        }

        static void drawTable(List<string> headers, List<List<string>> rows,
            int colWidth = 20, int buff = 2) {
            string buffer = new string(' ', buff);
            Console.WriteLine();
            for (int i = 0; i < headers.Count; i++) {
                string lim = limit(headers[i], colWidth - buff);

                Console.Write(buffer + lim +
                    new string(' ', colWidth - lim.Length));
            }
            Console.WriteLine();
            Console.WriteLine("\n" +
                new string('-', headers.Count * colWidth + buff * headers.Count) + "\n");

            foreach (var row in rows) {
                foreach (var entry in row) {
                    string lim = limit(entry, colWidth - buff);

                    Console.Write(buffer + lim +
                        new string(' ', colWidth - lim.Length));
                }
                Console.WriteLine();
            }
        }

        static string limit(string value, int len) {
            if (value.Length <= len)
                return value;

            string append = new string('.', len > 3 ? 3 : 0);

            return value.Remove(len - append.Length) + append;
        }
    }
}
