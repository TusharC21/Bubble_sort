/*
Author:Tushar Chotlani
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
    Bubble Sort without using swap function. 
    No input is required for the script. It will execute without 
    input against pre-populated arrays. 
*/

using System;

class BubbleSortExample
{
    static void Main()
    {
        // Initialize array with values
        int[] array = { 5, 72, 3, 14, 7, 1 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Sort the array using Bubble Sort
        BubbleSort(array);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
