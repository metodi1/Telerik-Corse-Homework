using System;

class TaskFive_P05
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double result = 1;
        int counter = 1;
        int facturel = 1;

        //logic
        while (counter <= n)
        {
            int nFacturel = facturel * counter;
            facturel = nFacturel;
            double s = result + nFacturel / (Math.Pow(x, counter));
            result = s;
            counter++;
        }

        //output
        Console.WriteLine("{0:0.00000}", result);

    }
}