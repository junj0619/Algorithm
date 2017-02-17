using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 9, 7, 3, 1, 6, 3, 2, 6, 8, 9, 3, 0 };
            var sorter = new MergSort(inputArray.Length);

            MergSort.Sort(ref inputArray);

            for (int i = 0; i < inputArray.Length; i++)
                Console.WriteLine(inputArray[i]);
        }
    }
}
