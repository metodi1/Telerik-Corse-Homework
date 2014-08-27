using System;

class ReadYourAge
{
    static void Main()
    {
        Console.Title = "ReadYourAge";
        Console.WriteLine("Enter your age:");
        int curAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Age after ten years is:" + (curAge+=10 ));
    }
}
