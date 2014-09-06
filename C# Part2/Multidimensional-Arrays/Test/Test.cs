using System;


class Test
    {
    static void Main()
        {
        //input
        Console.Write("Enter array lenght:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
            {
            array[i] = int.Parse(Console.ReadLine());
            }

        for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i] );
            }

        Console.WriteLine();
        }
    }