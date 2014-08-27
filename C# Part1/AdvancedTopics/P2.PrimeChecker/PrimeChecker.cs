﻿using System;
using System.Numerics;

//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

class PrimeChecker
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

        //Check with a metod IsPrime()
        bool prime = IsPrime(inputNumber);

        //Print the boolean result
        Console.WriteLine(prime);
    }

    public static bool IsPrime(BigInteger n)
    {
        //Test whether the parameter is a prime number
        
        if ((n & 1) == 0)
        {
            if (n == 2)
            {
                return true;   
            }
            else
            {
                return false;
            }
        }

        for (BigInteger i = 3; (i*i) <= n; i+=2)
        {
            if ((n % i) == 0)
            {
                return false;
            }
        }
        return n != 1;
    }
}