using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.


class CopyrightSymbolTriangle
{
    static void Main()
    {
        Console.Title = "Copyright Symbol Triangle";
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char copyrightSymbiol = '\u00A9';
        //Console.WriteLine(copyrightSymbiol - Metod1);
        int rows = int.Parse(Console.ReadLine());
        int cell = rows;
        int i = 0;
        for (; i < rows; i++, cell--)
        {
            Console.Write(new string(' ', cell - 1));
            Console.WriteLine(new string(copyrightSymbiol, (2 * i) + 1));
        }

        //Console.WriteLine(copyrightSymbiol - Metod2);
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyRight = '\u00A9';
            int rowsSecond = 3;
            int character = 1;
            for (int a = 0; a < rowsSecond; a++)
            {
                for (int blank = 0; blank < rowsSecond - a; blank++)
                {
                    Console.Write(" ");
                }
                for (int symbol = 0; symbol < character; symbol++)
                {
                    Console.Write(copyRight);
                }
                character += 2;
                Console.WriteLine();
            }
        }
    }
}