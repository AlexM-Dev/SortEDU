using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_EDU {
    static class Algorithms {
        public static void InsertionSort_1(ref int[] arr) {
            // Start at 1.
            int i = 1;

            // Increment slowly.
            while (i < arr.Length) {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j]) {
                    // Swap variables.
                    int v = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = v;
                    j = j - 1;
                }
                i = i + 1;
            }
        }

        public static void InsertionSort_2(ref int[] arr) {
            for (int i = 1; i < arr.Length; i++) {
                int j = i;
                // While the previous item is more than the current item.
                while (j > 0 && arr[j - 1] > arr[j]) {
                    // Swap the numbers. Ew.
                    int v = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = v;
                    j--;
                }
            }
        }
    }
}
