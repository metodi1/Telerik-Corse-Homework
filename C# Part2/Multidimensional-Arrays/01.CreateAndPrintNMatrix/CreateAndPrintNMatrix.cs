using System;

class CreateAndPrintNMatrix
    {
    static void Main()
        {
        ////input
        Console.Write("Enter size matrix n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int count = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                matrix[i, j] = count;
                count++;
                }
            }

        ////output
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                Console.Write("{0,3}", matrix[i, j]);
                }

            Console.WriteLine();

            }

        Console.WriteLine();

        }
    }