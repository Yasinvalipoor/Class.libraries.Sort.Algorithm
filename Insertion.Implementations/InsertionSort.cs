using InterfaceSort;

namespace Insertion.Implementations
{
    public class InsertionSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
