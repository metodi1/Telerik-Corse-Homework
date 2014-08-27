using System;

//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

class ZeroSubset
{
    static void Main()
    {
        Console.Title = "Zero Subset";
        Console.Write("Enter first nimber:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second nimber:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter third nimber:");
        int e = int.Parse(Console.ReadLine());
        int result = 0;
        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, d, e);
        }
        else
        {

            if ((a + b) == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, b, c, d, e);
            }
            if ((a + b + c) == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, c, d, e);
            }
            if ((a + b + c + d) == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, d, e);
            }
            if ((a + b + c + d + e) == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((a + b + d + e) == 0)
            {
                Console.WriteLine("{0}+{1}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((a + b + e) == 0)
            {
                Console.WriteLine("{0}+{1}+{4}=0", a, b, c, d, e);
            }
            if ((a + b + c + e) == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{4}=0", a, b, c, d, e);
            }
            if ((a + c) == 0)
            {
                Console.WriteLine("{0}+{2}=0", a, b, c, d, e);
            }
            if ((a + c + d) == 0)
            {
                Console.WriteLine("{0}+{2}+{3}=0", a, b, c, d, e);
            }
            if ((a + c + d + e) == 0)
            {
                Console.WriteLine("{0}+{2}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((a + c + e) == 0)
            {
                Console.WriteLine("{0}+{2}+{4}=0", a, b, c, d, e);
            }
            if ((a + d) == 0)
            {
                Console.WriteLine("{0}+{3}=0", a, b, c, d, e);
            }
            if ((a + d + e) == 0)
            {
                Console.WriteLine("{0}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((a + e) == 0)
            {
                Console.WriteLine("{0}+{4}=0", a, b, c, d, e);
            }
            if ((b + c) == 0)
            {
                Console.WriteLine("{1}+{2}=0", a, b, c, d, e);
            }
            if ((b + c + d) == 0)
            {
                Console.WriteLine("{1}+{2}+{3}=0", a, b, c, d, e);
            }
            if ((b + c + d + e) == 0)
            {
                Console.WriteLine("{1}+{2}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((b + c + e) == 0)
            {
                Console.WriteLine("{1}+{2}+{4}=0", a, b, c, d, e);
            }
            if ((b + d) == 0)
            {
                Console.WriteLine("{1}+{3}=0", a, b, c, d, e);
            }
            if ((b + d + e) == 0)
            {
                Console.WriteLine("{1}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((b + e) == 0)
            {
                Console.WriteLine("{1}+{4}=0", a, b, c, d, e);
            }
            if ((c + d) == 0)
            {
                Console.WriteLine("{2}+{3}=0", a, b, c, d, e);
            }
            if ((c + d + e) == 0)
            {
                Console.WriteLine("{2}+{3}+{4}=0", a, b, c, d, e);
            }
            if ((c + e) == 0)
            {
                Console.WriteLine("{2}+{4}=0", a, b, c, d, e);
            }
            if ((d + e) == 0)
            {
                Console.WriteLine("{3}+{4}=0", a, b, c, d, e);
            }
        }

    }
}