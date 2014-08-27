using System;

//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class CheckPointsWithinTheCircleAndTheRectangle
{
    static void Main()
    {
        Console.Title = "Check Points X and Y";
        int centerCircleX = 1;
        int centerCircleY = 1;
        int radius = 3;
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());
        if ((((pointX - centerCircleX) * (pointX - centerCircleX)) + ((pointY - centerCircleY) * (pointY - centerCircleY)) <= radius * radius) && pointX >= -1 && pointX <= 5 && pointY >= -1 && pointY <= 1)
        {
            Console.WriteLine("The point (x, y) is in");
        }
        else
            Console.WriteLine("The point (x, y) isn't in");
    }
}