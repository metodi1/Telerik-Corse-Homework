using System;
using System.Numerics;
class HW_Calculate
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int counter = 1;
        BigInteger result = 1;
        BigInteger nFacturel = 1;
        BigInteger kFacturel = 1;
        BigInteger knFacturel = 1;
        int sumKN = n - k;
        int sumcounter = 1;

        if (1 > k || n < k || n>100)
        {
            Console.WriteLine("Enter number K>1 and N>K and N<100:");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
        }

        //logic
        while (counter <= n)
        {

            if (counter <= k)
            {
                BigInteger subKfacturel = kFacturel * counter;
                kFacturel = subKfacturel;
            }
            BigInteger subNfacturel = nFacturel * counter;
            nFacturel = subNfacturel;

            while (sumcounter <= sumKN)
            {
                BigInteger subKNfacturiel = knFacturel * sumcounter;
                knFacturel = subKNfacturiel;
                sumcounter++;
            }            
            counter++;
        }
        result = nFacturel / (kFacturel * knFacturel);

        //output
        Console.WriteLine(result);
    }
}