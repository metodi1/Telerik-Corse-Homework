using System;

//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

class CheckTowIntIsBiger
{
    static void Main()
    {
        Console.Title = "Check Tow Int Is Biger";
        Console.Write("Enter first nimber:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second nimber:");
        int secondNumber = int.Parse(Console.ReadLine());
        int bigerNumber = firstNumber;
        if (secondNumber > firstNumber)
        {
            bigerNumber = secondNumber;
        }
        Console.WriteLine("Bigernumber is:{0}", bigerNumber);
    }
}