using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
        bool result=true;
        BigInteger test;
        //Test whether the parameter is a prime number

        //
        if (((test= inputNumber & 1)) == 0)
        {
            Console.WriteLine(test);
            if (inputNumber == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        Console.WriteLine(test);
        for (BigInteger i = 3; (i * i) <= inputNumber; i += 2)
        {
            if ((inputNumber % i) == 0)
            {
                result = false;
            }
        }

        if (inputNumber != 1)
        {
            Console.WriteLine(result); 
        }
        else
        {
            result = false;
            Console.WriteLine(result);
        }
    }
}