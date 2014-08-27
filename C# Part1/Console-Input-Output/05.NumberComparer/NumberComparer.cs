using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

class NumberComparer
{
    static void Main()
    {
        Console.Title = "Number Comparer";
        Console.Write("Enter First number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter Second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("The great number:" + Math.Max(first, second));
    }
}