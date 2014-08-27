using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).

class CalculateNFacturelOverKFacturel
{
    static void Main()
    {
        Console.Title = "Calculate N! / K!";
        Console.Write("Enter number N > 1, N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K > 1 and K < N, K = ");
        int k = int.Parse(Console.ReadLine());
        int counter = 1;
        int facturel = 1;

        if (k <=n)
        {
            Console.Write("Enter number N > 1, N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter number K > 1 and K < N, K = ");
            k = int.Parse(Console.ReadLine());
        }

        while (counter <= n)
        {
            if (counter > k)
            {
                facturel = facturel * counter;
            }
            counter++;
        }
        Console.WriteLine("Result : {0}", facturel);
    }
}