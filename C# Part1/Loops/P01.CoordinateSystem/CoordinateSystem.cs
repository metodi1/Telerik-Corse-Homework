using System;


class CoordinateSystem
{
    static void Main()
    {
        //input
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int result = 0;

        //logic
        if (x == 0 && y == 0)
        {
            result = 0;
        }
        else if (x > 0 && y > 0)
        {
            result = 1;
        }
        else if (x < 0 && y > 0)
        {
            result = 2;
        }
        else if (x < 0 && y < 0)
        {
            result = 3;
        }
        else if (x > 0 && y < 0)
        {
            result = 4;
        }
        else if (x == 0 && y != 0)
        {
            result = 5;
        }
        else if (x != 0 && y == 0)
        {
            result = 6;
        }

        //output
        Console.WriteLine(result);
    }
}