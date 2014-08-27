using System;

//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//    0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"

class ConvertNumbers
{
    //Method for the digits (0 to 9)
    public static void Digits(int number)
    {
        switch (number)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default: break;
        }
    }

    //Method for the special case (10 to 19)
    public static void SpecialCase(int number)
    {
        switch (number)
        {
            case 10: Console.WriteLine("Ten"); break;
            case 11: Console.WriteLine("Eleven"); break;
            case 12: Console.WriteLine("Twelve"); break;
            case 13: Console.WriteLine("Thirteen"); break;
            case 14: Console.WriteLine("Fourteen"); break;
            case 15: Console.WriteLine("Fifteen"); break;
            case 16: Console.WriteLine("Sixteen"); break;
            case 17: Console.WriteLine("Seventeen"); break;
            case 18: Console.WriteLine("Eighteen"); break;
            case 19: Console.WriteLine("Nineteen"); break;
            default: break;
        }
    }

    //Method for tens
    public static void Tens(int number)
    {
        switch (number)
        {
            case 2: Console.WriteLine("Twenty"); break;
            case 3: Console.WriteLine("Thirty"); break;
            case 4: Console.WriteLine("Fourty"); break;
            case 5: Console.WriteLine("Fifty"); break;
            case 6: Console.WriteLine("Sixty"); break;
            case 7: Console.WriteLine("Seventy"); break;
            case 8: Console.WriteLine("Eighty"); break;
            case 9: Console.WriteLine("Ninety"); break;
            default: break;
        }
    }

    //Method for hundreds
    public static void Hundreds(int number)
    {
        switch (number)
        {
            case 1: Console.WriteLine("One Hundred"); break;
            case 2: Console.WriteLine("Two Hundred"); break;
            case 3: Console.WriteLine("Three Hundred"); break;
            case 4: Console.WriteLine("Four Hundred"); break;
            case 5: Console.WriteLine("Five Hundred"); break;
            case 6: Console.WriteLine("Six Hundred"); break;
            case 7: Console.WriteLine("Seven Hundred"); break;
            case 8: Console.WriteLine("Eight Hundred"); break;
            case 9: Console.WriteLine("Nine Hundred"); break;
            default: break;
        }
    }

    //Main Method
    static void Main()
    {
        Console.Title = "Convert Numbers to Words";
        Console.WriteLine("Enter number into 0 to 999:");
        Console.Write("Enter number: ");
        int firstDigit;
        int secondDigit;
        int thirdDigit;
        int digits;
        int number;
        number = int.Parse(Console.ReadLine());

        while (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input. Only numbers in the range [0-999]");
            Console.WriteLine();
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }

        //Digits
        if (number < 10)
        {
            Digits(number);
        }

        //Special case
        if (number > 9 && number < 20)
        {
            SpecialCase(number);
        }

        //Tens
        if (number >= 20 && number < 100)
        {
            firstDigit = number / 10;
            secondDigit = number % 10;
            

            if (secondDigit == 0)
            {
                Tens(firstDigit);
            }
            else
            {
                Tens(firstDigit);
                Digits(secondDigit);
            }
        }

        //Hundreds
        if (number > 99)
        {
            firstDigit = number / 100;
            secondDigit = (number / 10) % 10;
            thirdDigit = number % 10;
            digits = number % 100;
            Hundreds(firstDigit);

            //check for special cases (10 to 19)
            if (digits >= 10 && digits < 20)
            {
                Console.Write("and ");
                SpecialCase(digits);
            }

            // check for zero in third and second digit
            if (digits == 0)
            {
                Hundreds(digits);
            }
            else if (digits != 0 && !(digits >= 10 && digits < 20))
            {
                Console.Write("and ");
                Tens(secondDigit);
                if (thirdDigit != 0 && !(digits >= 10 && digits < 20))
                {
                    Digits(thirdDigit);
                }
            }
        }
    }
}