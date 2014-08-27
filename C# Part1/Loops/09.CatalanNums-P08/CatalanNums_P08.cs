using System;
class CatalanNums_P08
{
    static void Main()
    {
        //input
        double n = double.Parse(Console.ReadLine());
        double nFact = 1;
        double factNominator = 1;
        double factDenominator = 1;
        double catalan = 1;


        //logic
        if (n>0)
        {
            for (double i = 1, j = n + 1; i <= n; i++, j++)
            {
                factNominator *= i*j;
                factDenominator *= i + 1;
                nFact *= i;
            }
            catalan = factNominator / (factDenominator * nFact);
            Console.WriteLine("Catalan number is equal to {0}", catalan);
        }
        else if (n == 0)
        {
            Console.WriteLine("Catalan number is:{0}", 1);
        }
        else
        {
            Console.WriteLine("Error! N mast be bigger or equal to 0");
           
        }
        //output






        //for (int i = 0; i <= 10; i++)
        //{
        //    PrintHyphens(i);
        //}

    }
    //static void PrintHyphens(int count)
    //{
    //    Console.WriteLine(new string('-', count));
    //}

}