using System;

//Write an expression that calculates rectangle’s area by given width and height.

class CalcRechtangekArea
{
    static void Main()
    {
        Console.Title = "Calculate Rechtangle's Area";
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Calculate Rechtangle's Area");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int area = firstNumber * secondNumber;
        Console.WriteLine("Area of rechtangle is: {0}", area);
        if (firstNumber < secondNumber)
        {
            Console.WriteLine("Height of rechtangle is: {0}\nWidth of rechtangle is: {1}", firstNumber, secondNumber);
        }
        else
            Console.WriteLine("Height of rechtangle is: {0}\nWidth of rechtangle is: {1}", secondNumber, firstNumber);
    }
}