using System;
class SpiralMatrix_P19
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (1 > n || n > 20)
        {
            Console.Write("Enter number between 1 to 20:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        int[,] spiralMatrix = new int[n, n];
        string direction = "right";
        int row = 0;
        int col = 0;

        //logic to fill of matrix
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (col > (n - 1) || spiralMatrix[row, col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }

            if (direction == "down" && (row > (n - 1) || spiralMatrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }

            if (direction == "left" && (col < 0 || spiralMatrix[row, col] != 0))
            {
                direction = "up";
                row--;
                col++;
            }

            if (direction == "up" && (row < 0 || spiralMatrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            //fill of matrix
            spiralMatrix[row, col] = i;
            //...............................................................

            if (direction == "right")
            {
                col++;
            }

            if (direction == "down")
            {
                row++;
            }

            if (direction == "left")
            {
                col--;
            }

            if (direction == "up")
            {
                row--;
            }
        }

        // output - print spiral matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-4}", spiralMatrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}