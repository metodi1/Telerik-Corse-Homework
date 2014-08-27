using System;
using System.Numerics;


class Tribonacci
{
    static void Main()
    {
        //input
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 0;

        //logic

        if (n == 1)
        {
            result = t1;
        }
        else if (n == 2)
        {
            result = t2;
        }
        else if (n == 3)
        {
            result = t3;
        }
        else
        {
            for (int i = 4; i <= n; i++)
            {
                BigInteger nextT = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = nextT;
                result = t3;
            }
        }

        //output
        Console.WriteLine(result);
    }
}