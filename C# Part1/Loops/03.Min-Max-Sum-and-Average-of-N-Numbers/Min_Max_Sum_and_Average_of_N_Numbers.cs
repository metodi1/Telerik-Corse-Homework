using System;
using System.Linq;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 
class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        Console.Title = "Min Max Sum and Average of N Numbers";
        Console.Write("Enter number N = ");
        int n = int.Parse(Console.ReadLine());
        //int n = 5;
        int[] number = new int[n];
        int counter = 0;
        int sum = 0;
        int checkNumber = 0;
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;

        while (counter < n)
        {
            Console.Write("Enter number: ");
            number[counter] = int.Parse(Console.ReadLine());
            
            
            counter++;
        }

       // int[] number = { -1, 255, -325, 0, 25 };

        checkNumber = number[0];

        foreach (int result in number)
        {

            //Console.Write("{0} ", result);
            sum = sum + result;



            if (checkNumber < result)
            {
                if (maxNumber < result)
                {
                    maxNumber = result;
                }

            }
            else
            {
                if (minNumber > result)
                {
                    minNumber = result;
                }

            }
        }
        Console.WriteLine();
        Console.WriteLine("MaxNumber : {0}",number.Max());
        Console.WriteLine("MinNumber : {0}",number.Min());
        Console.WriteLine();
        Console.WriteLine(" MinNumber = {0}\r\n MaxNumber = {1}\r\n Sum = {2}\r\n Averange = {3:0.00}", minNumber, maxNumber, sum, (float)sum / n);
        Console.WriteLine();
    }
}