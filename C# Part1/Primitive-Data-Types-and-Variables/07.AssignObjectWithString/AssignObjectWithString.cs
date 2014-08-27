using System;

//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables
//(mind adding an interval). Declare a third string variable and initialize it with the value of the object
//variable (you should perform type casting).


class AssignObjectWithString
{
    static void Main()
    {
        Console.Title = "Assing Object With String";
        string hello = "Hello";
        string world = "World";
        object twoStrings = hello + " " + world;
        string valueOfObject = (string)twoStrings;
        Console.WriteLine(twoStrings);
        Console.WriteLine(valueOfObject);
    }
}