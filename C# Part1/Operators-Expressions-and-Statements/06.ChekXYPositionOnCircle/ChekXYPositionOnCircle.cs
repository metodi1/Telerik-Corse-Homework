using System;

////Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class ChekXYPositionOnCircle
{
    static void Main(string[] args)
    {
        //Console.Title = "Chek position X and Y";
        //int x = 0;
        //int y = 5;
        //int inputX = int.Parse(Console.ReadLine());
        //int inputY = int.Parse(Console.ReadLine());
        //if (inputX <= y && inputY <= y)
        //{
        //    Console.WriteLine("X and Y is in circle");
        //}
        //else
        //    Console.WriteLine("X and Y is dont in circle");

        Console.Title = "Chek position X and Y";
        int x = 0;
        int radius = 5;
        int inputX = int.Parse(Console.ReadLine());
        int inputY = int.Parse(Console.ReadLine());
        if (inputX*inputX + inputY*inputY <= radius*radius)
        {
            Console.WriteLine("X and Y is in circle");
        }
        else
            Console.WriteLine("X and Y is dont in circle");
    }
}