using System;

//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

class NumbersNotDivisibleBy3and7
{
    static void Main()
    {
        Console.Title = "Numbers Not Divisible By 3 an 7";
        Console.Write("Enter number N = ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        Console.Write("Result is:");

        while (counter <= number)
        {
            if (counter % 3 != 0 && counter % 7 != 0)
            {
                Console.Write(" {0}", counter);
            }
            counter++;
        }
        Console.WriteLine();
    }
}