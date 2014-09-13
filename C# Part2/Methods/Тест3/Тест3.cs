using System;


class Тест3
{
    static void Print(string text)
    {
        Console.WriteLine(text);
    }

    static void Print(int number)
    {
        Console.WriteLine(number);
    }

    static void Print(string text, int number)
    {
        Console.WriteLine(text + ' ' + number);
    }
    static double FahrentheitToCelcsius(double degrees)
    {
        double celcsius = (degrees - 32) * 5 / 9;
        return celcsius;
    }

    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (int element in elements)
        {
            sum += element;            
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Temperature in Fahranheit:");
        double t = Double.Parse(Console.ReadLine());
        t = FahrentheitToCelcsius(t);
        Console.WriteLine("Temperature in Celsius: {0}", t);

        Print(4);
        Print("d");
        Print("s", 3);

        CalcSum(2,3,4,5,6,4,5);
        Console.WriteLine(CalcSum(2, 5));
        Console.WriteLine(CalcSum(4, 0, -2, 12));
        Console.WriteLine(CalcSum());
    }
}