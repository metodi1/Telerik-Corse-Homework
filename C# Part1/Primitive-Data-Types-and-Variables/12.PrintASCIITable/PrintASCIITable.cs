using System;

//Find online more information about ASCII (American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console.


class PrintASCIITable
{
    static void Main()
    {
        Console.Title = "Print ASCII Table";
        int z = 0;      //number
        int x = 0;      //psizion first colum
        int a = 10;     //psizion next colum
        int c = 30;     //psizion next colum
        int b = 20;     //psizion next colum
        int d = 40;     //psizion next colum
        int e = 50;     //psizion next colum
        int f = 60;     //psizion next colum
        int y = Console.CursorTop;

        for (int i = 0; i < 20; i++, z++, y++)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
        y = 0;
        for (int k = 0; k < 20; k++, z++, y++)
        {
            Console.SetCursorPosition(a, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
        y = 0;
        for (int l = 0; l < 20; l++, z++, y++)
        {
            Console.SetCursorPosition(b, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
        y = 0;
        for (int m = 0; m < 20; m++, z++, y++)
        {
            Console.SetCursorPosition(c, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
        y = 0;
        for (int n = 0; n < 20; n++, z++, y++)
        {
            Console.SetCursorPosition(d, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
        y = 0;
        for (int o = 0; o < 20; o++, z++, y++)
        {
            Console.SetCursorPosition(e, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
        y = 0;
        for (int p = 0; p < 20; p++, z++, y++)
        {
            Console.SetCursorPosition(f, y);
            Console.WriteLine("{0} -> {1}", z, (char)z);
        }
    }
}