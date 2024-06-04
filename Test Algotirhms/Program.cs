using Bubble.Implementations;
using Heap.Implementations;
using Insertion.Implementations;
using InterfaceSort;
using Merge.Implementations;
using Quick.Implementations;
using Selection.Implementations;
using Shell.Implementations;


int[] array1 = { 38, 27, 43, 3, 9, 82, 10 };
ISortable<int> mergesort = new MergeSort<int>();
mergesort.Sort(array1);

Console.WriteLine("\nMergeSort\nSorted array:");
foreach (var item in array1)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");

int[] array2 = { 12, 11, 13, 5, 6, 7 };
ISortable<int> heapsort = new HeapSort<int>();
heapsort.Sort(array2);

Console.WriteLine("HeapSort\nSorted array:");
foreach (var item in array2)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");

int[] array3 = { 12, 34, 54, 2, 3 };
ISortable<int> shellsort = new ShellSort<int>();
shellsort.Sort(array3);

Console.WriteLine("ShellSort\nSorted array:");
foreach (var item in array3)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");

int[] array4 = { 64, 25, 12, 22, 11 };
ISortable<int> selectionsort = new SelectionSort<int>();
selectionsort.Sort(array4);

Console.WriteLine("SelectionSort\nSorted array:");
foreach (var item in array4)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");

int[] array5 = { 12, 11, 13, 5, 6 };
ISortable<int> insertionsort = new InsertionSort<int>();
insertionsort.Sort(array5);

Console.WriteLine("InsertionSort\nSorted array:");
foreach (var item in array5)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");

int[] array6 = { 12, 11, 13, 5, 6, 6546, 312, 1, 647, 121 };
ISortable<int> bubblesort = new BubbleSort<int>();
bubblesort.Sort(array6);

Console.WriteLine("BubbleSort\nSorted array:");
foreach (var item in array6)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");

int[] array7 = { 102, 8, 1221, 5, 6, 44, 312, 1, 564, 97, 83274 };
ISortable<int> quicksort = new QuickSort<int>();
quicksort.Sort(array7);

Console.WriteLine("QuickSort\nSorted array:");
foreach (var item in array7)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n--------------------------------------\n");