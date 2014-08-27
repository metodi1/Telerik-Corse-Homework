using System;

class MatrixOfNumbers_P09
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        if (1 > n || n > 20)
        {
            Console.Write("Enter number between 1 to 20:");
            n = int.Parse(Console.ReadLine());
        }

        //logic
        for (int i = 1; i <= n; i++)
        {
            int counter = i;
            while (counter < n + i)
            {
                Console.Write("{0,3}", counter);
                counter++;
            }
            Console.WriteLine();
        }
    }
}