using System;
/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
*/


class BiggerFromItsNeighbours
{
    public static bool BiggerThanItsNeghbours(int[] array, int position)
    {
        if (position >= 1 && position <= array.Length - 2)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
        
    }
    static void Main()
    {
        Console.WriteLine("Enter positon number: ");
        int position = int.Parse(Console.ReadLine());
        int[] array = { 1, 4, 9, 3, 7, 8, 2, 6 };

        if (BiggerThanItsNeghbours(array, position))
        {
            Console.WriteLine("The number is bigger!");
        }
        else
        {
            Console.WriteLine("The number is smoller!");
        }
        Console.WriteLine();
    }
}