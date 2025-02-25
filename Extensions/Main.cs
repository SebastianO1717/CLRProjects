using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 5, 6 };
        BubbleSort(arr);

        Console.WriteLine("Sorted array: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    static void BubbleSort(int[] arr)
    {
        // Incorrect loop condition - will not sort the array fully
        for (int i = 0; i < arr.Length; i++) // Should iterate less for each pass
        {
            for (int j = 0; j < arr.Length - 1; j++) // This loop is incorrect since it doesn't reduce the range after each pass
            {
                if (arr[j] > arr[j + 1]) // Swap if the element is greater than the next one
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
