using InterfaceSort;

namespace Merge.Implementations
{
    public class MergeSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            T[] tempArray = new T[array.Length];
            MergeSortHelper(array, tempArray, 0, array.Length - 1);
        }

        private void MergeSortHelper(T[] array, T[] tempArray, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }

            int middle = (leftStart + rightEnd) / 2;
            MergeSortHelper(array, tempArray, leftStart, middle);
            MergeSortHelper(array, tempArray, middle + 1, rightEnd);
            MergeHalves(array, tempArray, leftStart, rightEnd);
        }

        private void MergeHalves(T[] array, T[] tempArray, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left].CompareTo(array[right]) <= 0)
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }
                index++;
            }

            Array.Copy(array, left, tempArray, index, leftEnd - left + 1);
            Array.Copy(array, right, tempArray, index, rightEnd - right + 1);
            Array.Copy(tempArray, leftStart, array, leftStart, size);
        }
    }
}
