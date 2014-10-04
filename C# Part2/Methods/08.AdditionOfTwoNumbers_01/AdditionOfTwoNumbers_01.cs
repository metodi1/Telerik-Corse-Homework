using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AdditionOfTwoNumbers_01
{
    static string AddingDigits(string first, string second)
    {
        int[] firstArray = new int[first.Length];
        int[] secondArray = new int[second.Length];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = first[i] - 48;
        }

        for (int i = 0; i < second.Length; i++)
        {
            secondArray[i] = second[i] - 48;
        }

        int max = firstArray.Length;

        if (max < secondArray.Length)
        {
            max = secondArray.Length;
        }

        int[] addedDigits = new int[max - 1];
        int counter1 = 1;
        int counter2 = 1;
        int minus1 = addedDigits.Length - 1;
        int minus2 = addedDigits.Length - 1;

        for (int i = addedDigits.Length-1; i >0; i--)
        {
            while (minus1 > firstArray.Length)
            {
                counter1++;
                minus1--;
            }

            while (minus2 > secondArray.Length)
            {
                counter2++;
                minus2--;
            }

        }

        return "s";
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        string first = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string second = Console.ReadLine();

        Console.WriteLine(AddingDigits(first, second));
    }
}