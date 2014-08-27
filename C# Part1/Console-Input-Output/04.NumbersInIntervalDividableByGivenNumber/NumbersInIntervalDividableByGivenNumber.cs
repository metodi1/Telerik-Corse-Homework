using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        Console.Title = "Numbers In Interval Dividable By Given Number";
        Console.Write("Enter Start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter End number: ");
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p = ++p;
                i = i + 4;
            }
        }
        Console.WriteLine("P = " + p);
    }
}