using System;

//Which of the following values can be assigned to a variable of type
//float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

class FloatOrDouble
{
    static void Main()
    {
        Console.Title = "Print Float Or Double Type";
        Console.WriteLine(new string('-',40) + "\nExamle for Float or Double Type Variables\n");
        float firstFloatVariable = 12.345f;
        float secondFloatVariable = 3456.091f;
        double firstDoubleVariable = 34.567839023;
        double secondDoubleVariable = 8923.1234857;
        Console.WriteLine(new string('-',40));
        Console.WriteLine("\nThe Floating Type Variables is:\t {0},\t {1}", firstFloatVariable, secondFloatVariable);
        Console.WriteLine("\nThe Double Type Variables is:\t {0},\t {1}", firstDoubleVariable, secondDoubleVariable);
        Console.WriteLine(new string('-', 40));
        //float pi = 13.141592653589793238f;
        //Console.WriteLine("pi = {0}", pi);
    }
}