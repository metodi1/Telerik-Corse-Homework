using System;
class CalculateGCD_P17
{
    static void Main()
    {
        ////input
        //int a1 = int.Parse(Console.ReadLine()); ;
        //int b1 = int.Parse(Console.ReadLine()); ;
        //int r = 1;
        //int result = 0;

        ////logic
        //if (a1 == 0)
        //{
        //    result = b1;
        //}
        //else if (b1 == 0)
        //{
        //    result = a1;
        //}
        //else
        //{

        //    int a = Math.Abs(a1);
        //    int b = Math.Abs(b1);
        //    while (r != 0)
        //    {


        //        if (a > b)
        //        {
        //            result = r;
        //            r = a % b;
        //            a = b;
        //            b = r;
        //        }
        //        else
        //        {
        //            result = r;
        //            r = b % a;
        //            b = a;
        //            a = r;
        //        }
        //    }
        //}


        ////output
        //Console.WriteLine(result);


        int numA = int.Parse(Console.ReadLine());
        int numB = int.Parse(Console.ReadLine());

        int num1 = Math.Abs(numA);
        int num2 = Math.Abs(numB);

        while (num1 != 0 && num2 != 0)
        {
            if (num1 > num2)
            {
                num1 -= num2;
            }
            else
            {
                num2 -= num1;
            }
        }
        Console.WriteLine(Math.Max(num1, num2));
       
    }
}