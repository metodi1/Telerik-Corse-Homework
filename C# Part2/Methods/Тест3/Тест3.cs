using System;
using System.Linq;

class FindMaximalElement
{

    static void Main()
    {
        string a = "123";
        string b = "456";

        int[,] tmp = new int[a.Length - 1, b.Length];

        int carry = 0;

        for (int i = a.Length - 1; i >= 0; i--)
        {
            for (int j = b.Length-1; j >= 0; j--)
            {

                int num = a[i] * b[j];
                tmp[a.Length - 1 - i, j] = (num % 10) + carry;
                carry = num / 10;
                //int num = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
                //result.Add(num % 10);
                //carry = num / 10;
            }
        }

        for (int i = 0; i < tmp.GetLength(0); i++)
        {
            for (int j = 0; j < tmp.GetLength(1); j++)
            {

                Console.WriteLine(tmp[i, j]);
            }
            Console.WriteLine();
        }
    }
}