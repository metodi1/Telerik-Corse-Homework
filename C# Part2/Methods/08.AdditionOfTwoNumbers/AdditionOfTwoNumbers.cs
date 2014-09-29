using System;

/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
*/

class AdditionOfTwoNumbers
{
    public static decimal SumNumber(decimal number1, decimal number2)
    {
        string temp1 = number1.ToString();        
        string temp2 = number2.ToString();
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;
        decimal result = 0;
        int bigLenghtNumber = 0;

        if (temp1.Length > temp2.Length)
        {
            bigLenghtNumber = temp1.Length;
            firstNumber = temp1;
            secondNumber = temp2;
        }
        else
        {
            bigLenghtNumber = temp2.Length;
            firstNumber = temp2;
            secondNumber = temp1;
        }

        for (int i = bigLenghtNumber; i >= 0; i--)
        {
            result += (decimal)firstNumber[i] + (decimal)secondNumber[i];
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter number:");
        decimal number1 = decimal.Parse(Console.ReadLine());
        decimal number2 = decimal.Parse(Console.ReadLine());

        
        Console.WriteLine("\n{0,6}\n{1,6}\n-------\n{2}", number1, number2, SumNumber(number1, number2));
    }
}