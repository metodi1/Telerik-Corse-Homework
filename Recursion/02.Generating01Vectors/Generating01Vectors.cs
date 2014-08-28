using System;

class Generating01Vectors
{
    static void Gen01(int index, int[] vector)
    {
        if (index == -1)
        {
            
            return;
        }
        else
        {
            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(index - 1, vector);
            }
        }
    }

    //private static void Print(int[] vector)
    //{
    //    throw new NotImplementedException();
    //}
    static void Main()
    {
        int size = 8;
        int[] vector = new int[size];
        Gen01(size-1, vector);
    }
}