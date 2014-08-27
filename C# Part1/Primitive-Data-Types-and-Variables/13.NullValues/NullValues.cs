using System;

//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

class NullValues
{
    static void Main()
    {
        Console.Title = "Null Values";
        //Integer Null
        int? someInteger = null;
        Console.WriteLine("This is the integer with Null value -> " + someInteger);
        someInteger = 5;
         Console.WriteLine("This is the integer with 5 -> " + someInteger);
        //Double Null
         double? someDouble = null;
         Console.WriteLine("This is the double with Null value -> " + someDouble);
         someDouble = 2.5;
         Console.WriteLine("This is the double with 2.5 -> " + someDouble);
    }
}