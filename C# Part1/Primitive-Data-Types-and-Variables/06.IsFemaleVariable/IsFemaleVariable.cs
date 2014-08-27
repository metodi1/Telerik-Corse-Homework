using System;

//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.


class IsFemaleVariable
{
    static void Main()
    {
        Console.Title = "Print Is Female - True or False";
        bool isFemale = false;
        Console.WriteLine("Write \"1\" if you is Male and \"2\" if you is Female");
        int sex = int.Parse(Console.ReadLine());
        if (sex == 2)
        {
            isFemale = true;
        }
        Console.WriteLine("You are is Female is:" + isFemale);
    }
}