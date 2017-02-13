using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = InsertionSort(new int[] { 20, 4, 15, 12, 9, 2, 50, 44 });
            foreach (var e in array)
                Console.WriteLine(e);
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int element = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > element)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = element;
            }

            return array;
        }
    }
}
