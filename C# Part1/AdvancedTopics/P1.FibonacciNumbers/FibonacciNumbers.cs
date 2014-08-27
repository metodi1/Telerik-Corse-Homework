using System;
using System.Numerics;

//Define a method Fib(n) that calculates the nth Fibonacci number.
// Examples: n = 11, Fib(n) = 144

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("write the number:");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = Fib(n);
        Console.WriteLine(result);
    }

    public static BigInteger Fib(int n)
    {
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger nextNum;
       
        if (n == 0) return firstNumber;
        if (n == 1) return secondNumber;
        //if (n==0)
        //{
        //    nextNum = firstNumber;
        //    return nextNum;
        //}
        //else if (n==1)
        //{
        //    nextNum = secondNumber;
        //    return nextNum;
        //}
        else
        {
            for (int i = 1; i <= n; i++)
            {
                nextNum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNum;

                if (i == n)
                {
                    return nextNum;
                }
            }            
        }
        return 0;
    }
}