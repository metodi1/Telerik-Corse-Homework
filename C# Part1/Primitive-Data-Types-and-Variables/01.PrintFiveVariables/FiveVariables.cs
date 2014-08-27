using System;

class FiveVariables
{
    static void Main()
    {
        Console.Title = "Print-Five-Variables";
        Console.WriteLine(new string('-', 40) + "\n Example for five variables.\n");
        //52130, -115, 4825932, 97, -10000
        byte firstVariable = 97;
        sbyte secondVariable = -115;
        ushort thirdVariables = 52130;
        short forVariable = -10000;
        int fiveVeriable = 4825932;
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(" First variable\t is \"byte\"\t = {0}\n Second variable is \"sbyte\"\t = {1}\n Third variable\t is \"ushort\"\t = {2}\n For variable\t is \"short\"\t = {3}\n Five variable\t is \"int\"\t = {4}\n", firstVariable, secondVariable, thirdVariables, forVariable, fiveVeriable);
        Console.WriteLine(new string('-', 40));
    }
}