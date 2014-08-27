using System;

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

class ExchangeValues
{
    static void Main()
    {
        Console.Title = "Exchange Values";
        int firstIntVariable = 5;
        int secondIntVariable = 10;
        Console.WriteLine("Print Variables:\nFirst Variable:{0}\nSecond Variable:{1}", firstIntVariable, secondIntVariable);
        int tirdIntVariable = firstIntVariable;
        firstIntVariable = secondIntVariable;
        secondIntVariable = tirdIntVariable;
        Console.WriteLine("\nExchenge Value:\nFirst Variable:{0}\nSecond Variable:{1}", firstIntVariable, secondIntVariable);
    }
}