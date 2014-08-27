using System;

//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true


class CompareFloatingNumbers
{
    static void Main()
    {
        Console.Title = "Compare Floating Numbers";
        Console.WriteLine(new string('-', 40) + "\nExample for compare floating type of numbers.\n");
        Console.WriteLine(new string('-', 40));
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Compare number {0} = {1} is: True", firstNumber, secondNumber);
        }
        else
            Console.WriteLine("Compare number {0} = {1} is: False", firstNumber, secondNumber);
        Console.WriteLine(new string('-', 40));
    }
}