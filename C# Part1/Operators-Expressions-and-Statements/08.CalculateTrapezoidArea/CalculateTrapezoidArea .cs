using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

    class CalculateTrapezoidArea 
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculate Trapezoid Area";
            int sidesA = int.Parse(Console.ReadLine());
            int sidesB = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = (sidesA + sidesB) * height / 2;
            Console.WriteLine("The trapezoid area is: " + area);
        }
    }