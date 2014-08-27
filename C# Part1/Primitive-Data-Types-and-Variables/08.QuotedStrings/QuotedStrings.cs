using System;

//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//    Do the above in two different ways: with and without using quoted strings.

class QuotedStrings
{
    static void Main()
    {
        Console.Title = "Quoted String";
        string quotedString = "The \"use\" of quotations causes difficulties.";
        string withoutQuotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedString);
        Console.WriteLine(withoutQuotedString);
    }
}