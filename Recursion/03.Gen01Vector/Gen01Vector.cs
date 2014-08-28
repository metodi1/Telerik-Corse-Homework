using System;

class Gen01Vector
{
    static void Main()
    {
        int n = 5;
        Gen01(new int[n], 0);
    }

    public static void Gen01(int[] vector, int currentIndex)
    {
        if (currentIndex == vector.Length)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]);
            }
            Console.WriteLine();
            return;
        }

        vector[currentIndex] = 0;
        Gen01(vector, currentIndex + 1);

        vector[currentIndex] = 1;
        Gen01(vector, currentIndex + 1);
    }
}