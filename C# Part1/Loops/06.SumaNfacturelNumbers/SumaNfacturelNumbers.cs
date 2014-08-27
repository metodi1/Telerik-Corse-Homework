using System;
using System.Numerics;
class SumaNfacturelNumbers
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
        int sumKN = k - n;
        int sumcounter = 1;

        if (1 > n || n > k)
        {
            Console.WriteLine("Enter number N>1 and K>N:");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
        }

        //logic
        while (counter <= k)
        {
           
            if (counter <= n)
            {
                BigInteger subNfacturel = nFacturel * counter;
                nFacturel = subNfacturel;
            }
            BigInteger subKfacturel = kFacturel * counter;
            kFacturel = subKfacturel;
           
            while (sumcounter <= sumKN)
            {
                BigInteger subKNfacturiel = knFacturel * sumcounter;
                knFacturel = subKNfacturiel;
                sumcounter++;
            }
            //result = (nFacturel * kFacturel) / knFacturel;
            counter++;
        }
        result = (nFacturel * kFacturel) / knFacturel;

        //output
        Console.WriteLine(result);
    }
}