using System;

//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

class ValueOfBitAtPosition
{
    static void Main()
    {
        Console.Title = "Check Bit For X Position is Vlue 1";
        int checkNumber = int.Parse(Console.ReadLine());
        int checkPosition = int.Parse(Console.ReadLine());
        int mask = 1 << checkPosition;
        int numberAndMask = checkNumber & mask;
        int result = numberAndMask >> checkPosition;
        Console.WriteLine("The bit of position is: {0}", result);
    }
}