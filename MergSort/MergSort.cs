namespace MergSort
{
    public class MergSort
    {
        private static int[] _tempArray;

        public MergSort(int length)
        {
            _tempArray = new int[length];
        }

        public static void Sort(ref int[] inputArray)
        {
            Sort(ref inputArray, 0, inputArray.Length - 1);
        }

        private static void Sort(ref int[] inputArray, int start, int end)
        {
            if (end <= start) return;

            int mid = (start + end) / 2;
            Sort(ref inputArray, start, mid);
            Sort(ref inputArray, mid + 1, end);
            Merg(ref inputArray, start, mid, end);
        }

        public static void Merg(ref int[] inputArray, int start, int mid, int end)
        {
            int leftStart = start;
            int rightStart = mid + 1;

            for (int k = 0; k <= end; k++)
                _tempArray[k] = inputArray[k];

            for (int k = start; k <= end; k++)
            {
                if (leftStart > mid)
                {
                    inputArray[k] = _tempArray[rightStart];
                    rightStart++;
                }
                else if (rightStart > end)
                {
                    inputArray[k] = _tempArray[leftStart];
                    leftStart++;
                }
                else if (_tempArray[leftStart] > _tempArray[rightStart])
                {
                    inputArray[k] = _tempArray[rightStart];
                    rightStart++;
                }
                else
                {
                    inputArray[k] = _tempArray[leftStart];
                    leftStart++;
                }
            }


        }

    }
}