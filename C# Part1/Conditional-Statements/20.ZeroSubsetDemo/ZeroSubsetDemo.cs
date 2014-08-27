using System;

//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
class ZeroSubsetDemo
{
    static void Main()
    {
        Console.Title = "Zero Subset Demo";
        Console.Write("Enter the integer count:");
        int intCount = int.Parse(Console.ReadLine());
        int[] intArray = new int[intCount];

        for (int i = 0; i < intCount; i++)
        {
            Console.Write("Enter numbers:");
            intArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int subsetCount = 0;

        if (intArray[0] != 0 || intArray[1] != 0 || intArray[2] != 0 || intArray[3] != 0 || intArray[4] != 0)
        {
            for (int i = 0; i < intCount; i++)
            {
                for (int j = i + 1; j < intCount; j++)
                {
                    sum = intArray[i] + intArray[j];
                    if (sum == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2}", intArray[i], intArray[j], sum);
                        subsetCount++;
                    }
                    for (int k = j + 1; k < intCount; k++)
                    {
                        sum = intArray[i] + intArray[j] + intArray[k];
                        if (sum == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", intArray[i], intArray[j], intArray[k], sum);
                            subsetCount++;
                        }
                        for (int l = k + 1; l < intCount; l++)
                        {
                            sum = intArray[i] + intArray[j] + intArray[k] + intArray[l];
                            if (sum == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", intArray[i], intArray[j], intArray[k], intArray[l], sum);
                                subsetCount++;
                            }
                            for (int m = l + 1; m < intCount; m++)
                            {
                                sum = intArray[i] + intArray[j] + intArray[k] + intArray[l] + intArray[m];
                                if (sum == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", intArray[i], intArray[j], intArray[k], intArray[l], intArray[m], sum);
                                    subsetCount++;
                                }
                            }
                        }
                    }

                }
            }
            if (subsetCount == 0)
            {
                Console.WriteLine("no zero subset");
            }
            else
            {
                Console.WriteLine("There are {0} sums of subsets that are equal to Zero!", subsetCount);
            }
        }
        else
        {
            sum = intArray[1] + intArray[2] + intArray[3] + intArray[4];
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", intArray[0], intArray[1], intArray[2], intArray[3], intArray[4], sum);
            Console.WriteLine("There are 1 sums of subsets that are equal to Zero!");
        }
    }
}