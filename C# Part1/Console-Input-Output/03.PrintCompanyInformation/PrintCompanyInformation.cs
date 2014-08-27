using System;

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Title = "Print Company Information";
        Console.Write("Eter Company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Company address: ");
        string companyAdrress = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Company phone number: ");
        string companyTel = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Company fax number: ");
        string companyFax = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Company web site: ");
        string companySite = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Eter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Eter Phone number: ");
        string phone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company name:     {0}",companyName);
        Console.WriteLine("Company adrress:  {0}", companyAdrress);
        Console.WriteLine("Company phone:    {0}", companyTel);
        Console.WriteLine("Company fax:      {0}", companyFax);
        Console.WriteLine("Company web site: {0}", companySite);
        Console.WriteLine("Manager:          {0} {1}", firstName, lastName);
        Console.WriteLine("Age:              {0}", age);
        Console.WriteLine("Phone:            {0}", phone);
    }
}