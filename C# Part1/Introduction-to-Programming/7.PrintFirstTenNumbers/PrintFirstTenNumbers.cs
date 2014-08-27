using System;

class PrintFirstTenNumbers
{
    static void Main()
    {
        Console.Title = "Print First Ten Numbers";
        Console.Write("Print first ten numbers: ");
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i +", ");
            }
            else
            Console.Write(i*(-1) + ", ");
        }
        Console.WriteLine("\n");
    }
}