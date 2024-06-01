using InterfaceSort;

namespace Bubble.Implementations
{
    public class BubbleSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        // Swap array[j] and array[j + 1]
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
