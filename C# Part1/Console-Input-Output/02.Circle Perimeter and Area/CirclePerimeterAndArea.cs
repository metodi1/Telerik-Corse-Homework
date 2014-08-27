using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area.

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Title = "Circle Perimeter and Area";
        Console.Write("Enter radius of circle r: ");
        double radius = double.Parse(Console.ReadLine());
        float pi = 3.14159206f;
        Console.Write("Perimeter of circle is: {0:0.00}", 2*pi*radius);
        Console.WriteLine();
        Console.Write("Aea of circle is: {0:0.00}", pi * radius*radius);
        Console.WriteLine();
    }
}