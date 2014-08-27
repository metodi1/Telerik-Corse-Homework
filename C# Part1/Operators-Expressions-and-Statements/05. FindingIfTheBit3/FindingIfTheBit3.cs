using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


class FindingIfTheBit3
{
    static void Main()
    {
        Console.Title = "Finding if the bit 3 is 1 or 0";
        int bitForChek = 2;
        int number = int.Parse(Console.ReadLine());
        //int test = 1;
        int mask = 1 << bitForChek;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitForChek;

        Console.WriteLine("This number is input: \t\t" + Convert.ToString(number, 2).PadLeft(32, '0'));
        //Console.WriteLine("Tdis number is test: " + Convert.ToString(1, 2).PadLeft(32, '0'));
        Console.WriteLine("This number is mask: \t\t" + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine("This number is numberAndMask(&):" + Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
        Console.WriteLine("This number is bit: \t\t" + Convert.ToString(bit, 2).PadLeft(32, '0'));
        Console.WriteLine("Third bit is: {0}", bit);
    }
}