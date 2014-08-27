using System;

//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

class ShowsTheSign
{
    static void Main()
    {
        Console.Title = "Shows The Sign";
        Console.Write("Enter first nimber:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second nimber:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        int thirdtNumber = int.Parse(Console.ReadLine());
        if (firstNumber > 0)
        {
            Console.WriteLine("The sing of first bumber is (+)");
        }
        else
        {
            Console.WriteLine("The sing of first bumber is (-)");
        }
        if (secondNumber > 0)
        {
            Console.WriteLine("The sing of second bumber is (+)");
        }
        else
        {
            Console.WriteLine("The sing of second bumber is (-)");
        }
        if (thirdtNumber > 0)
        {
            Console.WriteLine("The sing of third bumber is (+)");
        }
        else
        {
            Console.WriteLine("The sing of third bumber is (-)");
        }
    }
}