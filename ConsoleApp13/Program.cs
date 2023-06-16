using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 8, 1, 9, 2 }; // создаем массив

        Console.WriteLine("Исходный массив: ");
        foreach (int a in array)
            Console.Write(a + " "); // выводим элементы массива

        SelectionSort(array); // сортировка выбором

        Console.WriteLine("\n\nМассив после сортировки выбором: ");
        foreach (int a in array)
            Console.Write(a + " "); // выводим элементы отсортированного массива

        HeapSort(array); // пирамидальная сортировка

        Console.WriteLine("\n\nМассив после пирамидальной сортировки: ");
        foreach (int a in array)
            Console.Write(a + " "); // выводим элементы отсортированного массива

        Console.ReadKey();
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[j] < arr[min])
                    min = j;
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);

        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            heapify(arr, i, 0);
        }
    }

    static void heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int l = 2 * i + 1;
        int r = 2 * i + 2;

        if (l < n && arr[l] > arr[largest])
            largest = l;

        if (r < n && arr[r] > arr[largest])
            largest = r;

        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            heapify(arr, n, largest);
        }
    }
}
