using InterfaceSort;

namespace Shell.Implementations
{
    public class ShellSort<T> : ISortable<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            int n = array.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    T temp = array[i];

                    int j;
                    for (j = i; j >= gap && array[j - gap].CompareTo(temp) > 0; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }

                    array[j] = temp;
                }
            }
        }
    }
}
