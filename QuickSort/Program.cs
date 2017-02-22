using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 12, 81, 74, 43, 1098, 0, 8, 92, 17, 754, 912, 0, 6, 4 };

            QuickSort(ref array, 0, array.Length - 1);

            foreach (var num in array)
            {
                Console.WriteLine(num);
            }

        }

        public static void QuickSort(ref int[] array, int start, int end)
        {
            if (start < end)
            {
                int p = Partition(ref array, start, end);
                QuickSort(ref array, start, p - 1);
                QuickSort(ref array, p + 1, end);
            }
        }

        private static int Partition(ref int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i = i + 1;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            array[end] = array[i + 1];
            array[i + 1] = pivot;
            return i + 1;
        }

    }
}
