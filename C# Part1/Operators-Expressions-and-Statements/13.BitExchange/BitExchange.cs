using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class BitExchange
{
    static void Main()
    {
        Console.Title = "Bit Exchenge";
        int checkNumber = int.Parse(Console.ReadLine());
        int maskPosition3 = 1 << 3;
        int maskPosition4 = 1 << 4;
        int maskPosition5 = 1 << 5;
        int maskPosition24 = 1 << 24;
        int maskPosition25 = 1 << 25;
        int maskPosition26 = 1 << 26;
        int bitsAndMaskPosition24 = checkNumber & maskPosition24;
        int bitsAndMaskPosition25 = checkNumber & maskPosition25;
        int bitsAndMaskPosition26 = checkNumber & maskPosition26;
        int bitsPosition24 = bitsAndMaskPosition24 >> 24;
        int bitsPosition25 = bitsAndMaskPosition25 >> 25;
        int bitsPosition26 = bitsAndMaskPosition26 >> 26;
        int maskPosition3Invert = ~(1 << 3);
        int maskPosition4Invert = ~(1 << 4);
        int maskPosition5Invert = ~(1 << 5);
        int result3;
        int result4;
        int result5;
        int result;
        //Exchenge Bit 3 with bit 24
        if (bitsPosition24 == 0)
        {
            result3 = checkNumber & maskPosition3Invert;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask24 \t\t:" + Convert.ToString(maskPosition24, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask3 \t\t:" + Convert.ToString(maskPosition3Invert, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number3 \t:" + Convert.ToString(result3, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result3);
        }
        else
        {
            result3 = checkNumber | maskPosition3;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask24 \t\t:" + Convert.ToString(maskPosition24, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask3 \t\t:" + Convert.ToString(maskPosition3Invert, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number3 \t:" + Convert.ToString(result3, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result3);
        }
        //Exchenge Bit 4 with bit 25
        if (bitsPosition25 == 0)
        {
            result4 = checkNumber & maskPosition4Invert;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask25 \t\t:" + Convert.ToString(maskPosition25, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask4 \t\t:" + Convert.ToString(maskPosition4Invert, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number4 \t:" + Convert.ToString(result4, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result4);
        }
        else
        {
            result4 = checkNumber | maskPosition4;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask25 \t\t:" + Convert.ToString(maskPosition25, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask4 \t\t:" + Convert.ToString(maskPosition4Invert, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number4 \t:" + Convert.ToString(result4, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result4);
        }
        //Exchenge Bit 4 with bit 26
        if (bitsPosition26 == 0)
        {
            result5 = checkNumber & maskPosition5Invert;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask26 \t\t:" + Convert.ToString(maskPosition26, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask5 \t\t:" + Convert.ToString(maskPosition5Invert, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number5 \t:" + Convert.ToString(result5, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result5);
        }
        else
        {
            result5 = checkNumber | maskPosition5;
            Console.WriteLine("Check number \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask26 \t\t:" + Convert.ToString(maskPosition26, 2).PadLeft(32, '0'));
            Console.WriteLine("Mask5 \t\t:" + Convert.ToString(maskPosition5Invert, 2).PadLeft(32, '1'));
            Console.WriteLine("Result number5 \t:" + Convert.ToString(result5, 2).PadLeft(32, '0'));
            Console.WriteLine("The result nuber is: {0}", result5);
        }
        int result10;
        if (bitsPosition25 == 0)
        {
            result10 = result3 & result4;
        }
        else
            result10 = result3 | result4;
        int result11;
        if (bitsPosition26 == 0)
        {
            result11 = result10 & result5;
        }
        else
            result11 = result10 | result5;
        int result2 = result3 | result4 | result5;
        int result6 = (result3 | result4 | result5) | (result3 & result4 & result5);
        result = result3 & result4 & result5;
        int mask = maskPosition3 | maskPosition4 | maskPosition5 | maskPosition24 | maskPosition25 | maskPosition26;
        Console.WriteLine("Check number     \t:" + Convert.ToString(checkNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("Mask    \t\t:" + Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine("Result   number \t:" + Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Result2  number \t:" + Convert.ToString(result2, 2).PadLeft(32, '0'));
        Console.WriteLine("Result6  number \t:" + Convert.ToString(result6, 2).PadLeft(32, '0'));
        Console.WriteLine("Result10 number \t:" + Convert.ToString(result10, 2).PadLeft(32, '0'));
        Console.WriteLine("Result11 number \t:" + Convert.ToString(result11, 2).PadLeft(32, '0'));
        Console.WriteLine("The result nuber   is: {0}", result);
        Console.WriteLine("The result2 nuber  is: {0}", result2);
        Console.WriteLine("The result6 nuber  is: {0}", result6);
        Console.WriteLine("The result10 nuber is: {0}", result10);
        Console.WriteLine("The result11 nuber is: {0}", result11);        
    }
}