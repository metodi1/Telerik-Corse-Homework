using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

class CheckPrimeNumber
{
    static void Main()
    {
        Console.Title = "Check The Number Is Prime";
        int integerNumber = int.Parse(Console.ReadLine());
        int n = integerNumber;
        if (n <= 100)
        {
            if (((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0) && (n % 9 != 0)) || (n == 2) || (n == 3) || (n == 5) || (n == 7) || (n == 9))
            {
                Console.WriteLine("The number is prime");
            }
            else
                Console.WriteLine("The number isn't prime");
        }
    }
}