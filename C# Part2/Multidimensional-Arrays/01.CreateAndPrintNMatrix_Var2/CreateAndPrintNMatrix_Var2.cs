﻿using System;
//  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class CreateAndPrintNMatrix_Var2
    {
    static void Main()
        {
        ////input
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool up = false;
        bool down = true;
        int row = 0;
        int col = 0;
        int maxRotation = (int)Math.Pow(n, 2);
        ////logic
        for (int i = 1; i < maxRotation + 1; i++)
            {
            if (up)
                {
                matrix[row, col] = i;
                row--;
                if (row == -1)
                    {
                    up = false;
                    down = true;
                    row++;
                    col++;
                    if (row == 0 & col == n/2)
                        {
                        continue;
                        }
                    if (col == n )
                        {
                        break;
                        }
                    }
                }

            if (down)
                {
                matrix[row, col] = i;
                row++;
                if (row == n)
                    {
                    up = true;
                    down = false;
                    row--;
                    col++;
                    }
                }
            }

        ////outout
        for (int rows = 0; rows < n; rows++)
            {
            for (int cols = 0; cols < n; cols++)
                {
                Console.Write("{0, 3}", matrix[rows, cols]);
                }
            Console.WriteLine();
            }
        }
    }