using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEvenNumbers
{
    static void Main()
    {
        Console.Title = "Odd or Even Number";
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Display the number is Odd or Even");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is: Even");
        }
        else
        Console.WriteLine("The number is: Odd");
    }
}