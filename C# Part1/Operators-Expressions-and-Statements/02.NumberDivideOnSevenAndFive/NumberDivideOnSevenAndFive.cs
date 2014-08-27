using System;

//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.


class NumberDivideOnSevenAndFive
{
    static void Main()
    {
        Console.Title = "Number who Divide on Seven And Five";
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Display number who divaide with seven and five");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Enter integer number from 0 to 100");
        for (int i = 0; i < 100; i++)
        {
            if (i % 7 == 0 && i % 5 == 0)
            {
                Console.WriteLine("Integer number who divide on 7 and 5 is: {0}", i);
            }
        }
    }
}