using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_EDU {
    static class Algorithms {
        public static void InsertionSort(ref int[] arr) {
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