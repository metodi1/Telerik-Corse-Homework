using System;

class Test2
{
    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(" {0}", i);
        }

        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter number n:");
        int n = int.Parse(Console.ReadLine());

        for (int line = 1; line <= n; line++)
        {
            PrintLine(1, line);
        }

        for (int line = n-1; line >= 1; line--)
        {
            PrintLine(1, line);
        }
    }
}