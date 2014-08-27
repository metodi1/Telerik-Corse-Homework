using System;
using System.Numerics;



//Problem 7.	Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:

//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. Examples:

class Calculat_P07
{

    static void Main()
    {
        //input
          
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nkFact = 1;

        //logic
        for (int i = 1, j = 1; i <= n; i++, j++)
        {
            nFact = i * nFact;
            if (j<=k)
            {
                kFact = j * kFact;
            }

            if (j<= (n-k))
            {
                nkFact = nkFact * j;
            }            
        }
        
        //output
        result = nFact / (kFact * nkFact);
        Console.WriteLine(result);
    }
}