using System;

//Write a program to find all possible placements of 8 queens on a chessboard
class The8QueensProblem
{
    static void Main()
    {
        int size = 8;
        SolveQueensProblem(new bool[size, size], new int[size, size], 0);
        Console.WriteLine(count);
    }

    static int count = 0;
    static void SolveQueensProblem(bool[,] board, int[,] occupied, int columIndex)
    {
        if (columIndex == 8)
        {
            count++;
            return;
        }

        for (int rowIndex = 0; rowIndex < 8; rowIndex++)
        {
            if (occupied[rowIndex, columIndex] == 0)
            {

                //Place queen board[rowIndex, columIndex]
                board[rowIndex, columIndex] = true;

                //Mark impossaible elements in board
                MarkOccupied(occupied, +1, rowIndex, columIndex);

                //Recursively call Queens
                SolveQueensProblem(board, occupied, columIndex + 1);
                board[rowIndex, columIndex] = false;

                //Un-mark impossible elements in board
                MarkOccupied(occupied, -1, rowIndex, columIndex);
            }
        }
    }

    static void MarkOccupied(int[,] occupied, int value, int column, int row)
    {
        for (int i = 0; i < occupied.GetLength(0); i++)
        {
            occupied[i, column] += value;
            occupied[row, i] += value;

            if (column + i < occupied.GetLength(0) && row + i < occupied.GetLength(0))
            {
                occupied[row + i, column + i] += value;
            }

            if (column + i < occupied.GetLength(0) && row - i >= 0)
            {
                occupied[row - i, column + i] += value;
            }
        }
    }
}