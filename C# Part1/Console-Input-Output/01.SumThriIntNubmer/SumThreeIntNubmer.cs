using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class SumThreeIntNubmer
{
    static void Main()
    {
        Console.Title = "Sum Three Number";
        Console.Write("Enter a: ");
        int inputA = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int inputB = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int inputC = int.Parse(Console.ReadLine());
        Console.Write("Sum three number is: {0}", inputA+inputB+inputC);
        Console.WriteLine();
    }
}
