using System;

//Write a program that finds the greatest of given 5 variables.
class GreatestOfFiveNumbers
{
    static void Main()
    {
        Console.Title = "Sort Three Number";
        Console.Write("Enter first nimber:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second nimber:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        double thirdtNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        double fourNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        double fivetNumber = double.Parse(Console.ReadLine());
        double biggestNumber = firstNumber;
        if (firstNumber == secondNumber && firstNumber == thirdtNumber && firstNumber == fourNumber && firstNumber == fivetNumber && secondNumber == thirdtNumber && secondNumber == fourNumber && secondNumber ==firstNumber && thirdtNumber == fourNumber && thirdtNumber == fivetNumber && fourNumber == fivetNumber)
        {
            Console.WriteLine("Not Biggest number");
        }
        else
        {
            if (secondNumber > firstNumber)
            {
                biggestNumber = secondNumber;
            }            
            if (thirdtNumber > biggestNumber)
            {
                biggestNumber = thirdtNumber;
            }
            if (fourNumber > biggestNumber)
            {
                biggestNumber = fourNumber;
            }
            if (fivetNumber > biggestNumber)
            {
                biggestNumber = fivetNumber;                
            }
            Console.WriteLine("Biggest of five number is: {0}", biggestNumber);
        }
    }
}