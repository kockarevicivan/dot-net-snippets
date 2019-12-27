using System.Linq;

namespace DotNetSnippets.Algorithms
{
    public class SortingService
    {
        public int[] BubbleSort(int[] original)
        {
            for (int i = 0; i < original.Length; i++)
                for (int j = 0; j < (original.Length - i) - 1; j++)
                    if (original[j + 1] < original[j])
                        Swap(original, j, j + 1);

            return original;
        }

        public int[] InsertionSort(int[] original)
        {
            for (int i = 0; i < original.Length; i++)
            {
                int j = i;

                while (j > 0 && original[j] < original[j - 1])
                    Swap(original, j, --j);
            }

            return original;
        }

        public int[] ExchangeSort(int[] original)
        {
            for (int i = 0; i < original.Length; i++)
                for (int j = i; j < original.Length; j++)
                    if (original[j] < original[i])
                        Swap(original, i, j);

            return original;
        }

        public int[] SelectionSort(int[] original)
        {
            for (int i = 0; i < original.Length; i++)
            {
                int minimumIndex = i;

                for (int j = i + 1; j < original.Length; j++)
                    if (original[j] < original[minimumIndex])
                        minimumIndex = j;

                Swap(original, i, minimumIndex);
            }

            return original;
        }

        public int[] MergeSort(int[] original)
        {
            if (original.Length == 1) return original;

            int middle = original.Length / 2;

            int[] left = MergeSort(original.Take(middle).ToArray());
            int[] right = MergeSort(original.Skip(middle).ToArray());

            return Merge(left, right);
        }

        public void QuickSort(int[] array, int start, int end)
        {
            if (start >= end) return;

            int pivot = Partition(array, start, end);

            if (pivot > 1)
                QuickSort(array, start, pivot - 1);

            if (pivot + 1 < end)
                QuickSort(array, pivot + 1, end);
        }


        private int Partition(int[] array, int start, int end)
        {
            int pivot = array[start];

            while (true)
            {
                while (array[start] < pivot)
                    start++;

                while (array[end] > pivot)
                    end--;

                if (start < end)
                    Swap(array, start, end);
                else
                    return end;
            }
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int leftIndex = 0, rightIndex = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (leftIndex >= left.Length && rightIndex >= right.Length)
                    break;
                else if (rightIndex >= right.Length)
                    result[i] = left[leftIndex++];
                else if (leftIndex >= left.Length)
                    result[i] = right[rightIndex++];
                else if (left[leftIndex] < right[rightIndex])
                    result[i] = left[leftIndex++];
                else if (rightIndex < right.Length)
                    result[i] = right[rightIndex++];
            }

            return result;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temporary = array[i];
            array[i] = array[j];
            array[j] = temporary;
        }
    }
}
