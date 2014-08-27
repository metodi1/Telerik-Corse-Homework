using System;

//Problem 13.	Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality

class BinaryToDecimalNumber_P13
{
    static void Main()
    {
        //1.Variant
        Console.WriteLine("1.Variant");

        //input
        string n = Console.ReadLine();
        long result = 0;
        int j = 0;
        long pow = 1;

        //logic
        for (int i = (n.Length - 1); i >= 0; i--)
        {
            int tmp = n[i] - 48;            
            pow = (long)Math.Pow(2, j);            
            result += tmp * pow;
            j++;           
        }

        //output
        Console.WriteLine(result);
        Console.WriteLine();

        //.............................................
        //2.Variant
        Console.WriteLine("2.Variant");

        //input
        string n1 = Console.ReadLine();
        long result1 = 0;        
        long pow1 = 1;

        //logic
        for (int i1 = (n1.Length - 1); i1 >= 0; i1--)
        {
            int tmp1 = n1[i1] - 48;
            pow1 = 1;            
            for (int j1 = 1; j1 <= ((n1.Length - 1) - i1); j1++)
            {
                pow1 *= 2;
            }
            result1 += tmp1 * pow1;            
        }

        //output
        Console.WriteLine(result1);

    }
}