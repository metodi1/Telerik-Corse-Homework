using System;
class DeckCards_P04
{
    static void Main()
    {
        //logic

        for (int i = 0; i < 4; i++)
        {

            Top(i);

            for (int j = 2; j < 15; j++)
            {

                switch (j)
                {
                    case 2: Left(i); Console.Write(" 2 "); PrintColors(i); Console.WriteLine(); break;
                    case 3: Left(i); Console.Write(" 3 "); PrintColors(i); Console.WriteLine(); break;
                    case 4: Left(i); Console.Write(" 4 "); PrintColors(i); Console.WriteLine(); break;
                    case 5: Left(i); Console.Write(" 5 "); PrintColors(i); Console.WriteLine(); break;
                    case 6: Left(i); Console.Write(" 6 "); PrintColors(i); Console.WriteLine(); break;
                    case 7: Left(i); Console.Write(" 7 "); PrintColors(i); Console.WriteLine(); break;
                    case 8: Left(i); Console.Write(" 8 "); PrintColors(i); Console.WriteLine(); break;
                    case 9: Left(i); Console.Write(" 9 "); PrintColors(i); Console.WriteLine(); break;
                    case 10: Left(i); Console.Write("10 "); PrintColors(i); Console.WriteLine(); break;
                    case 11: Left(i); Console.Write(" J "); PrintColors(i); Console.WriteLine(); break;
                    case 12: Left(i); Console.Write(" Q "); PrintColors(i); Console.WriteLine(); break;
                    case 13: Left(i); Console.Write(" K "); PrintColors(i); Console.WriteLine(); break;
                    case 14: Left(i); Console.Write(" A "); PrintColors(i); Console.WriteLine(); break;
                    default: break;
                }
            }

        }
        Console.WriteLine();
    }


    static void PrintColors(int i)
    {
        if (i == 0)
        {
            Console.Write("♣  ");
        }
        else if (i == 1)
        {
            Console.Write("♦  ");
        }
        else if (i == 2)
        {
            Console.Write("♥  ");
        }
        else if (i == 3)
        {
            Console.Write("♠  ");
        }
    }


    static void Top(int i)
    {
        if (i == 1)
        {
            Console.SetCursorPosition(6, 0);
        }
        else if (i == 2)
        {
            Console.SetCursorPosition(12, 0);
        }
        else if (i == 3)
        {
            Console.SetCursorPosition(18, 0);
        }
    }

    static void Left(int i)
    {
        if (i == 1)
        {
            Console.SetCursorPosition(6, Console.CursorTop);
        }
        else if (i == 2)
        {
            Console.SetCursorPosition(12, Console.CursorTop);
        }
        else if (i == 3)
        {
            Console.SetCursorPosition(18, Console.CursorTop);
        }


        // other solution
        //string[] facesCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //string[] colorsCards = { " ♣ ", " ♦", " ♥", " ♠" };

        //Console.WriteLine("Standart deck of 52 play cards contain:");
        //Console.WriteLine();
        //foreach (var face in facesCards)
        //{
        //    foreach (var color in colorsCards)
        //    {
        //        Console.Write("{0,3}{1} ", face, color);
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();

    }
}