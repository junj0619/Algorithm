using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = SelectionSort(new int[] { 54, 23, 1, 66, 90, 100, 4 });
            foreach (var element in array)
                Console.WriteLine(element);
        }


        public static int[] SelectionSort(int[] array)
        {

            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            return array;
        }
    }
}
