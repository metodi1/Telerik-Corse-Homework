using System;

//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

class WriteTheValueInThePosition
{
    static void Main()
    {
        Console.Title = "Check Bit For X Position is Vlue 1";
        int checkNumber = int.Parse(Console.ReadLine());
        int checkPosition = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int mask = value << checkPosition;
        int mask0 = ~(1 << checkPosition);
        int result;
        if (value == 0)
        {

            result = checkNumber & mask0;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask \t\t:" + Convert.ToString(mask0, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number \t:" + Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result);
        }
        else
        {
            result = checkNumber | mask;
            //int resultAndMask = result & mask;
            //int checkResult = resultAndMask >> checkPosition;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask \t\t:" + Convert.ToString(mask, 2).PadLeft(32, '0'));
            Console.WriteLine("Result number \t:" + Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result);
        }
    }
}