using System;
using System.Numerics;
	 

//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class FibonacciNumbers
{
    static void Main()
    {
        //Console.Title = "Fibonacci Numbers";
        //Console.Write("Enter n:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine();
        //int previous = -1;
        //int next = 1;
        //if (n > 0)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        int sum = next + previous; previous = next;
        //        next = sum;
        //        Console.Write("{0}, ", next);
        //    }
        //    Console.WriteLine();
        //}
        //else
        //{
        //    Console.WriteLine("Enter nuber > O");
        //}
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger sum = 0;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        for (int i = 1; i < 100; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(sum);
        }
    }
}