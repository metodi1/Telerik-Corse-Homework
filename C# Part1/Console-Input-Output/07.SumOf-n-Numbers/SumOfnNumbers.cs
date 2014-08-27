using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

class SumOfnNumbers
{
    static void Main()
    {
        Console.Title = "Sum Of n Numbers";
        Console.Write("Enter n:");        
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double sum = 0;
        for (int i = 0; i <n; i++)
        {
            Console.Write("Enter number:");
            double number = double.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine();
        Console.WriteLine("Sum Of n Numbers is: {0}", sum);
    }
}