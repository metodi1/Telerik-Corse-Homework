using System;

//Write a program that prints all the numbers from 1 to N.

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Title = "Numbers From 1 to N";
        Console.Write("N = ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        Console.Write("Result is:");

        while (counter <= number)
        {
            Console.Write(" {0}", counter);
            counter++;
        }
        Console.WriteLine();
    }
}