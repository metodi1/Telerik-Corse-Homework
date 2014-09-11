using System;

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }

    }

    public int Colums
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix();
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Colums; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }

        return result;
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }
}