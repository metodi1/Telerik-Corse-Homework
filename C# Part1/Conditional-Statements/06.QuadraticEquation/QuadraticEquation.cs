using System;

//Write a program that enters the coefficients a, b and c of a quadratic equation
//        a*x2 + b*x + c = 0
//        and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic Equation";
        Console.Write("Enter coefficients a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficients b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficients c:");
        double c = double.Parse(Console.ReadLine());
        double determinant = (b * b) - ((4 * a) * c);
        if (determinant >= 0)
        {
            if (determinant != 0)
            {


                if (a == 0)
                {
                    double x = -(c / b);
                    Console.WriteLine("Have one real roots:");
                    Console.WriteLine("x = {0}",x);
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(determinant)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(determinant)) / (2 * a);
                    Console.WriteLine("Have two real roots:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
            }
            else
            {
                double x = -(b/(2*a));
                Console.WriteLine("Have one real roots:");
                Console.WriteLine("x = {0}", x);
            }
        }
        else
        {
            Console.WriteLine("Not real roots");
        }
    }
}