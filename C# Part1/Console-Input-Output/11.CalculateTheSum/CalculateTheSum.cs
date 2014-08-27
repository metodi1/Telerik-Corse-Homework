using System;

//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

class CalculateTheSum
{
    static void Main()
    {
        Console.Title = "Calculate The Sum";
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double sum = 1;
        Console.Write("{0} + ", sum);
        double param = 1;
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                param = (double)1 / i;
                Console.Write("1/{0} + ", i);
            }
            else
            {
                param = (double)-1 / i;
                Console.Write("(-1/{0}) + ", i);
            }
            sum = sum +param;
        }       
        Console.WriteLine(" = {0:0.000}",sum);
    }
}