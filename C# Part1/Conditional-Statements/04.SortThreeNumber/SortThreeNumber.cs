using System;

//Sort 3 real values in descending order using nested if statements.

class SortThreeNumber
{
    static void Main()
    {
        Console.Title = "Sort Three Number";
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
                    Console.WriteLine(firstNumber);
                    if (secondNumber > thirdtNumber)
                    {
                        Console.WriteLine(secondNumber);
                        Console.WriteLine(thirdtNumber);
                    }
                    else
                    {
                        Console.WriteLine(thirdtNumber);
                        Console.WriteLine(secondNumber);
                    }
                }
                else
                {
                    Console.WriteLine(thirdtNumber);
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);
                }
            }
            else
            {
                if (secondNumber > thirdtNumber)
                {
                    Console.WriteLine(secondNumber);
                    if (firstNumber > thirdtNumber)
                    {
                        Console.WriteLine(firstNumber);
                        Console.WriteLine(thirdtNumber);
                    }
                    else
                    {
                        Console.WriteLine(thirdtNumber);
                        Console.WriteLine(firstNumber);
                    }
                }
                else
                {
                    Console.WriteLine(thirdtNumber);
                    Console.WriteLine(secondNumber);
                    Console.WriteLine(firstNumber);
                }
            }
        }
    }
}