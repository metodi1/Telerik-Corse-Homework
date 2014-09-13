using System;

class Test
{
    static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negativ", number);
        }
        else
        {
            Console.WriteLine("The number {0} is zero", number);
        }
    }

    static void PrintMax(float number1, float number2)
    {
        float max = number1;
        if (number2 > number1)
        {
            max = number2;
        }

        Console.WriteLine("Maximal number: {0}", max);
    }

    static void SayMonth(int month)
    {
        string[] monthNames = new string[] {
            "Jenuary", "February", "March", "April", "May", "June", "July", "August", "September", "Octouber", "November", "December"};
        Console.WriteLine(monthNames[month -1]);
    }

    static void SayPeriod(int startMonth, int endMonth)
    {
        int period = endMonth - startMonth;
        if (period<0)
        {
            period = period + 12;
        }

        Console.Write("There are {0} months from ", period);
        SayMonth(startMonth);
        Console.Write(" to ");
        SayMonth(endMonth);
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("For period enter start month: ");
        int startMonth = int.Parse(Console.ReadLine());
        Console.Write("For period enter end month: ");
        int endMonth = int.Parse(Console.ReadLine());
        PrintSign(number);
        PrintMax(5, 2);
        PrintMax(-5, 2);
        SayMonth(9);
        SayPeriod(startMonth, endMonth);
    }
}