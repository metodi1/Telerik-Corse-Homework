using System;

//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

class BitForPositionIsValue1
{
    static void Main()
    {
        Console.Title = "Check Bit For X Position is Vlue 1";
        int checkNumber = int.Parse(Console.ReadLine());
        int checkPosition = int.Parse(Console.ReadLine());
        int mask = 1 << checkPosition;
        int numberAndMask = checkNumber & mask;
        int result = numberAndMask >> checkPosition;
        if (result == 1)
        {
            Console.WriteLine("Result is True");
        }
        else
            Console.WriteLine("Result is False");
    }
}