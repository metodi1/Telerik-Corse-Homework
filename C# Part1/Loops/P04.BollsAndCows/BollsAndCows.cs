using System;

class BollsAndCows
{
    static void Main()
    {

        //input
        string secret = Console.ReadLine();
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        bool hasSolution = false;
        bool isFirst = true;
        
        //logic
        for (int num = 1111; num <= 9999; num++)
        {
            int bulls = 0;
            int cows = 0;
            bool[] isVisited = new bool[4];
            string numStr = num.ToString();

            //check for zero
            bool hasZero = false;
            for (int i = 0; i < numStr.Length; i++)
            {
                if (numStr[i] == '0')
                {
                    hasZero = true;
                }
            }

            if (hasZero)
            {
                continue;
            }

            //bolls
            for (int i = 0; i < numStr.Length; i++)
            {
                if (secret[i] == numStr[i])
                {
                    bulls++;
                    isVisited[i] = true;
                }
            }

            //cows
            for (int i = 0; i < numStr.Length; i++)
            {
                if (!isVisited[i])
                {
                    for (int j = 0; j < numStr.Length; j++)
                    {
                        if (i != j && !isVisited[j] && secret[i] == numStr[j])
                        {
                            cows++;
                            isVisited[j] = true;
                        }
                    }
                }
            }

            //output
            if (b == bulls && c == cows)
            {
                hasSolution = true;

                if (isFirst)
                {
                    Console.Write(numStr);
                }
                else
                {
                    Console.Write(" {0}", numStr);
                }
                isFirst = false;
            }
        }

        if (!hasSolution)
        {
            Console.WriteLine("No");
        }
    }
}