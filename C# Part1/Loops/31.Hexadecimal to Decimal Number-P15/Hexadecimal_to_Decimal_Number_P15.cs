using System;

//Problem 15.	Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 


class Hexadecimal_to_Decimal_Number_P15
{
    static void Main()
    {
        //input
        string hexaInput = Console.ReadLine(); ;
        long result = 0;
        long subResult = 1;
        int power = 0;

        //logic
        for (int i = (hexaInput.Length - 1); i >= 0; i--)
        {
            string charToString = "0" + "x" + hexaInput[i];
            int charToInt = Convert.ToInt32(charToString, 16);
            subResult = (long)Math.Pow(16, power);
            result += charToInt * subResult;
            power++;
        }

        //output
        Console.WriteLine(result);
    }
}