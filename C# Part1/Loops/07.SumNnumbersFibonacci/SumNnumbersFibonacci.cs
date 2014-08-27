using System;
using System.Numerics;
class SumNnumbersFibonacci
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int counter = 2;
        int result = 1;
        int n1 = 0;
        int n2 = 1;
        int fibunN = 0;

        //logic
        while (counter <= n)
        {
            fibunN = n1+n2;
            n1=n2;
            n2 = fibunN; ;
            int sumFibunN = result+fibunN;
            result = sumFibunN;
            counter++;
        }
        //output
        Console.WriteLine(result);
    }
}