using InterfaceSort;

namespace Quick.Implementations
{
    public class QuickSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            QuickSortAlgorithm(array, 0, array.Length - 1);
        }

        private void QuickSortAlgorithm(T[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSortAlgorithm(array, low, pi - 1);
                QuickSortAlgorithm(array, pi + 1, high);
            }
        }

        private int Partition(T[] array, int low, int high)
        {
            T pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;

                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            T swapTemp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = swapTemp;

            return i + 1;
        }
    }
}

