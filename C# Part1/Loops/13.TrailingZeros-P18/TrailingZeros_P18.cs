using System;
using System.Numerics;

class TrailingZeros_P18
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;           
        int counter=0;

        //lpgic
        for (int i = 2; i <= n; i++)
        {
            nFact = nFact * i;
        }

        while (nFact % 10 == 0)
        {            
            nFact /= 10;            
            counter++;
        }
        
        //output
        Console.WriteLine(counter);        
    }
}