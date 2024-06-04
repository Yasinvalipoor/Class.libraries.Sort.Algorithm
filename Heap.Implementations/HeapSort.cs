using InterfaceSort;

namespace Heap.Implementations
{
    public class HeapSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                T temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
        }

        void Heapify(T[] array, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && array[left].CompareTo(array[largest]) > 0)
                largest = left;

            if (right < n && array[right].CompareTo(array[largest]) > 0)
                largest = right;

            if (largest != i)
            {
                T swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                Heapify(array, n, largest);
            }
        }
    }
}
