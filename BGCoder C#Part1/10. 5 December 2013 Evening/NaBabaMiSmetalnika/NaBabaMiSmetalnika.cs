using System;

class NaBabaMiSmetalnika
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        int[,] matrix = new int[8, n];

        int[] testNumber = new int[n];;

        for (int row0 = 0; row0 < matrix.GetLength(0); row0++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int col0 = 0; col0 < matrix.GetLength(1); col0++)
            {
                matrix[row0, col0] = (number >> col0) & 1;
            }
        }


        //solution
        string comand = String.Empty;
        int row = 0;
        int col = 0;
        while (comand != "stop")
        {
            comand = Console.ReadLine();

            if (comand == "right")
            {
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
                //// test 
                //for (int j = 0; j < n; j++)
                //{
                //    testNumber[j] = matrix[row, j];
                //}
                //foreach (var num in testNumber)
                //{
                //    Console.Write(num);
                //}

                //string num1 = String.Empty;
                //foreach (var item in testNumber)
                //{
                //    num1 += testNumber[item].ToString();
                //}
                //int test = int.Parse(num1);
                //Console.WriteLine(test);

                for (int i = 0; i <= col; i++)
                {
                    if (matrix[row, i] == 1 && i > 0)
                    {
                        col = i;
                        while (matrix[row, col] != 0)
                        {
                            matrix[row, col] = (matrix[row, col] << 1) | matrix[row, col];
                            col++;
                        }

                    }
                }

            }
        }

        //print
        for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
        {
            for (int col1 = matrix.GetLength(1) - 1; col1 >= 0; col1--)
            {
                if (matrix[row1, col1] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row1, col1] == 1)
                {
                    Console.Write('*');
                }

            }

            Console.WriteLine();
        }

    }
}