using System;

//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

class FreeBitsExchenges
{
    static void Main()
    {
        Console.Title = "Bit Exchenge";
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q:");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k:");
        int k = int.Parse(Console.ReadLine());
        int maskp = 1 << p;
        int maskq = 1 << q;
        int resultLast;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        for (int i = 0; i < k; i++)
        {
            maskp = 1 << p + i;
            maskq = 1 << q + i;
            int maskqInvert = ~maskq;
            Console.WriteLine(Convert.ToString(maskp, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(maskq, 2).PadLeft(32, '0'));
            int nAndMaskp = n & maskp;
            int nAndMaskq = n & maskq;
            //int nAndMaskqInvert = ~nAndMaskq;
            Console.WriteLine(Convert.ToString(nAndMaskp, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(nAndMaskq, 2).PadLeft(32, '0'));
            int result;
            if (nAndMaskq == 0)
            {
                result = n & nAndMaskq >> (maskq - maskp);
            }
            else
            {
                result = n | (maskq - maskp);
            }
            int[] resultNew = { result };
            int z = i - 1;
            if (z<=0)
            {
                z = 0;
            }

            Console.WriteLine(z);
            Console.WriteLine(resultNew);
            if (nAndMaskq == 0)
            {
                resultLast = resultNew[z] & resultNew[i];
            }
            else
            {
                resultLast = resultNew[z] | resultNew[2];
            }
            Console.WriteLine(Convert.ToString(resultLast, 2).PadLeft(32, '0'));
            Console.WriteLine(resultLast);
        }
    }
}