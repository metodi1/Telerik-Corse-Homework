using System;

class PrintTheSqrtNumbers
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.Title = "The Square of 12345";
        Console.WriteLine("Print Sqrt Number");
        int number = 12345;
        Console.WriteLine("\nThe Square of is " + number + " = " + number * number + "\n");
        Console.WriteLine("The Square of is {0} = {1}", number, number*number);
    }
}