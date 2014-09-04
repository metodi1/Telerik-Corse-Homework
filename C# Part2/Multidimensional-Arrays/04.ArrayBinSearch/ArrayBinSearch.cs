using System;
using System.Collections.Generic;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

class ArrayBinSearch
{
    //static void GetArray()
    //{
    //    List<string> list = new List<string>();
    //    for (int i = 0; i < 10; i++)
    //    {
    //        list.Add()
    //    }
    //}
    static void PrintArray(int[] array)
    {
        int size = (int)Math.Log10(array.Length);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(Convert.ToString(array[i]).PadRight(size, ' '));
        }
    }

    static void Main()
    {
        ////input
        int N = 10;
        Random rdn = new Random();
        
         int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = rdn.Next();
        }

        foreach (var item in array)
        {
            Console.Write(Convert.ToString(array.Length).PadRight(3, ' '));
        }
        

        PrintArray(array);
    }
}