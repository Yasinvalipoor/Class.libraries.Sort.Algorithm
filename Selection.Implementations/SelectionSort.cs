using InterfaceSort;

namespace Selection.Implementations
{
    public class SelectionSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                T temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
