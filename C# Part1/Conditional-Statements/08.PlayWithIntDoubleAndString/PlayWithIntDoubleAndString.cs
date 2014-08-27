using System;

//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Title = "Play With Int Double And String";
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Enter value:");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
            case 2:
                Console.Write("Please enter a double:");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("The value is: {0}", value+1);
                break;
            case 3: 
                Console.Write("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine("The value is: {0}", str + "*");
                break;
            default: Console.WriteLine("Error"); break;
        }
    }
}