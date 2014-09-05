using System;
using System.Collections.Generic;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

////Exzamle:
////
////Source array that is ordered ascendin.
////
////string[] arrayTwo = { "a", "e", "m", "n", "x", "z" };
////
////Call versions of the BinarySearch method.
////int indez1 = Array.BinarySearch(arrayTwo, "m");
////int index2 = Array.BinarySearch<string>(arrayTwo, "x");
////int index3 = Array.BinarySearch<string>(arrayTwo, "E", StringComparer.OrdinalIgnoreCase);
////
////Write result.
////
////Console.WriteLine(indez1);
////Console.WriteLine(index2);
////Console.WriteLine(index3);

class ArrayBinSearch
{
    static void SortArray(int[] array, int left, int right)
    {
        int pointLeft = left;
        int pointRight = right;
        int pivot = array[(left +right)/2];

        while (pointLeft <= pointRight)
        {
            while (pointLeft.CompareTo(array[pivot])<0)
            {
                pointLeft++;
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                int tmpElement = array[i];
                array[i] = array[i - 1];
                array[i - 1] = tmpElement;
            }
        }

        Console.WriteLine(string.Join(",", array));
    }

    static void PrintArray(int[] array)
    {        
        Console.Write(string.Join(",", array));
        Console.WriteLine();
    }

    static void Main()
    {
        ////input
        int N = 10;
        int k = 15;
        Random rdn = new Random();

        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = rdn.Next(1, 100);
        }

    
       
        Console.WriteLine();

    }
}