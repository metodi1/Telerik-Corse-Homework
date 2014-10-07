using System;
using System.Linq;

class FindMaximalElement
{

    static void Main()
    {
        string a = "123";
        string b = "456";
        int counter = 0;

        int[] first = new int[a.Length];
        int[] second = new int[b.Length];

        int[,] matrix = new int[second.Length, first.Length + 1];

        for (int i = 0; i < first.Length; i++)
        {
            first[i] = a[i] - 48;
        }

        for (int i = 0; i < b.Length; i++)
        {
            second[i] = b[i] - 48;
        }

        for (int row = second.Length - 1; row >= 0; row--)
        {
            for (int col = first.Length; col > 0; col--)
            {
                if (second[row] * first[col - 1] < 10)
                {
                    matrix[row, col] += second[row] * first[col - 1];
                }

                if (second[row] * first[col - 1] >= 10)
                {
                    matrix[row, col] += second[row] * first[col - 1] % 10;
                    matrix[row, col - 1] += second[row] * first[col - 1] / 10;

                }
            }
        }

        //Print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}