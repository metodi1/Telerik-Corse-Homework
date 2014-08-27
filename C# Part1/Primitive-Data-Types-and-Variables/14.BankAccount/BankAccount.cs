using System;

//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.

class BankAccount
{
    static void Main()
    {
        Console.Title = "Bank Account";
        Console.Write("\nEnter First Name:");
        string firstName = Console.ReadLine();
        Console.Write("\nEnter Midle Name:");
        string middleName = Console.ReadLine();
        Console.Write("\nEnter Last Name:");
        string lastName = Console.ReadLine();
        Console.Write("\nEnter Balanse:");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("\nEnter Bank Name:");
        string bankName = Console.ReadLine();
        Console.Write("\nEnter IBAN:");
        string iban = Console.ReadLine();
        Console.Write("\nEnter BIC:");
        string bic = Console.ReadLine();
        Console.Write("\nEnter Number of Credit Cart One:");
        ulong numberFirstCreditCart = ulong.Parse(Console.ReadLine());
        Console.Write("\nEnter Number of Credit Cart One:");
        ulong numberSecondCreditCart = ulong.Parse(Console.ReadLine());
        Console.Write("\nEnter Number of Credit Cart One:");
        ulong numberThirdCreditCart = ulong.Parse(Console.ReadLine());
        Console.WriteLine("\nName: {0}\nBalanse: {1}\nBank: {2}\nIBAN: {3}\nBIC: {4}\nID First Cart: {5}\nID Second Cart: {6}\nID Third Cart: {7}\n", firstName + " " + middleName + " " + lastName, balance, bankName, iban, bic, numberFirstCreditCart, numberSecondCreditCart, numberThirdCreditCart);

    }
}