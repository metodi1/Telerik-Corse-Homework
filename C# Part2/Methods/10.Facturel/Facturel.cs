using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/

class Facturel
{
    static bool IsCorrectNumber(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < '0' || number[i] > '9')
            {
                return false;
            }
        }

        return true;
    }

    static List<int> AddingTwoNumber(string number1, string number2)
    {
        var a = number1.Select(ch => ch - '0').ToArray();
        var b = number2.Select(ch => ch - '0').ToArray();

        Array.Reverse(a);
        Array.Reverse(b);

        List<int> result = new List<int>(Math.Max(a.Length, b.Length)+1);
        int[,] tmp = new int[a.Length-1, b.Length];

        int carry = 0;

        for (int i = a.Length-1; i >= 0; i--)
        {
            for (int j = b.Length; j >= 0; j--)
            {

                int num = a[i] * b[j];
                tmp[a.Length-1-i,j]=(num % 10) + carry;
                carry = num / 10;
                //int num = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
                //result.Add(num % 10);
                //carry = num / 10;
            }
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count-1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }

        Console.WriteLine("\n");
    }
    static void Main()
    {
        string number1 = "123";
        string number2 = "456";

        if (IsCorrectNumber(number1) && IsCorrectNumber(number2))
        {
            List<int> result = AddingTwoNumber(number1, number2);

            Console.Write("\nNumber1{0,8}\nNumber2{1,8}\n", number1, number2);
            Console.Write(new string('-', 16));
            Console.Write("\nResult:     ");
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("\n-> You have entered an invalid number(s)...\n");
        }
    }
}