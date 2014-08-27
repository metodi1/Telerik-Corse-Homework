using System;

//Write a program that finds the biggest of three integers using nested if statements.

class BiggestOfThreeIntegers
{
    static void Main(string[] args)
    {
        Console.Title = "Biggest Of Three Integers";
        Console.Write("Enter first nimber:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second nimber:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        int thirdtNumber = int.Parse(Console.ReadLine());
        if (firstNumber == secondNumber && firstNumber == thirdtNumber)
        {
            Console.WriteLine("Not Biggest number");
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdtNumber)
                {
                    Console.WriteLine("First number is Biggest");
                }
                else
                {
                    Console.WriteLine("Third number is Biggest");
                }
            }
            else
            {
                if (secondNumber > thirdtNumber)
                {
                    Console.WriteLine("Second number is Biggest");
                }
                else
                {
                    Console.WriteLine("Third number is Biggest");
                }
            }
        }
    }
}