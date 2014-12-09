using System;

class ShipDamage
{
    public static int CalculateDamage(int cX, int cY, int smallX, int bigX, int smallY, int bigY, int h)
    {
        int result = 0;

        // Calculate damage of C
        int damageC;
        if (h > 0 && cY < 0)
        {
            damageC = (int) Math.Abs(cY) + h;
        }
        else
        {
            damageC = (int) Math.Abs(cY) - (int) Math.Abs(h);
        }

        if (cX < smallX || cX > bigX)
        {
            result += 0;
        }
        else
        {
            if (damageC < smallY - h || damageC > bigY - h)
            {
                result += 0;
            }
            else if (damageC == smallY - h || damageC == bigY - h)
            {
                if (cX == smallX || cX == bigX)
                {
                    result += 25;
                }
                else
                {
                    result += 50;
                }
            }
            else
            {
                if (cX == smallX || cX == bigX)
                {
                    result += 50;
                }
                else
                {
                    result += 100;
                }
            }
        }
        return result;
    }
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());
        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());
        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        int result = 0;
        int bigX = 0;
        int smallX = 0;
        int bigY = 0;
        int smallY = 0;

        if (sX1 > sX2)
        {
            bigX = sX1;
            smallX = sX2;
        }
        else
        {
            bigX = sX2;
            smallX = sX1;
        }

        if (sY1 > sY2)
        {
            bigY = (int) Math.Abs(sY1);
            smallY = (int) Math.Abs(sY2);
        }
        else
        {
            bigY = (int) Math.Abs(sY2);
            smallY = (int) Math.Abs(sY1);
        }

        Console.WriteLine(CalculateDamage(cX1, cY1, smallX, bigX, smallY, bigY, h) + "%");
        Console.WriteLine(CalculateDamage(cX2, cY2, smallX, bigX, smallY, bigY, h) + "%");
        Console.WriteLine(CalculateDamage(cX3, cY3, smallX, bigX, smallY, bigY, h) + "%");

        result += CalculateDamage(cX1, cY1, smallX, bigX, smallY, bigY, h);
        result += CalculateDamage(cX2, cY2, smallX, bigX, smallY, bigY, h);
        result += CalculateDamage(cX3, cY3, smallX, bigX, smallY, bigY, h);
        Console.WriteLine(result + "%");
        return;

        //// Calculate damage of C1
        //int damageC1;
        //if (h > 0)
        //{
        //    damageC1 = (int) Math.Abs(cY1) + h;
        //}
        //else
        //{
        //    damageC1 = (int) Math.Abs(cY1) - (int) Math.Abs(h);
        //}

        //if (cX1 < smallX || cX1 > bigX)
        //{
        //    result += 0;
        //}
        //else
        //{
        //    if (damageC1 < smallY -h || damageC1 > bigY - h)
        //    {
        //        result += 0;
        //    }
        //    else if (damageC1 == smallY - h || damageC1 == bigY - h)
        //    {
        //        if (cX1 == smallX || cX1 == bigX)
        //        {
        //            result += 25;
        //        }
        //        else
        //        {
        //            result += 50;
        //        }
        //    }
        //    else
        //    {
        //        if (cX1 == smallX || cX1 == bigX)
        //        {
        //            result += 50;
        //        }
        //        else
        //        {
        //            result += 100;
        //        }
        //    }
        //}

        //// Calculate damage of C2
        //int damageC2;
        //if (h > 0)
        //{
        //    damageC2 = (int) Math.Abs(cY2) + h;
        //}
        //else
        //{
        //    damageC2 = (int) Math.Abs(cY2) - (int) Math.Abs(h);
        //}

        //if (cX2 < smallX || cX2 > bigX)
        //{
        //    result += 0;
        //}
        //else
        //{
        //    if (damageC2 < smallY - h || damageC2 > bigY - h)
        //    {
        //        result += 0;
        //    }
        //    else if (damageC2 == smallY - h || damageC2 == bigY - h)
        //    {
        //        if (cX2 == smallX || cX2 == bigX)
        //        {
        //            result += 25;
        //        }
        //        else
        //        {
        //            result += 50;
        //        }
        //    }
        //    else
        //    {
        //        if (cX2 == smallX || cX2 == bigX)
        //        {
        //            result += 50;
        //        }
        //        else
        //        {
        //            result += 100;
        //        }
        //    }
        //}

        //// Calculate damage of C3
        //int damageC3;
        //if (h > 0)
        //{
        //    damageC3 = (int) Math.Abs(cY3) + h;
        //}
        //else
        //{
        //    damageC3 = (int) Math.Abs(cY3) - (int) Math.Abs(h);
        //}

        //if (cX3 < smallX || cX3 > bigX)
        //{
        //    result += 0;
        //}
        //else
        //{
        //    if (damageC3 < smallY - h || damageC3 > bigY - h)
        //    {
        //        result += 0;
        //    }
        //    else if (damageC3 == smallY - h || damageC3 == bigY - h)
        //    {
        //        if (cX3 == smallX || cX3 == bigX)
        //        {
        //            result += 25;
        //        }
        //        else
        //        {
        //            result += 50;
        //        }
        //    }
        //    else
        //    {
        //        if (cX3 == smallX || cX3 == bigX)
        //        {
        //            result += 50;
        //        }
        //        else
        //        {
        //            result += 100;
        //        }
        //    }
        //}

        //Console.WriteLine(result + "%");
    }
}