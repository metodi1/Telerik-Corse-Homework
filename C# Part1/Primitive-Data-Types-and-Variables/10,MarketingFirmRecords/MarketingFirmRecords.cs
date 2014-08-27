using System;

//A marketing firm wants to keep record of its employees. Each record would have the following characteristics 
//– first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.


class MarketingFirmRecords
{
    static void Main()
    {
        Console.Title = "Marketing Firm Records";
        Console.WriteLine(new string('-', 40) + "\nEnter your information:\n");
        Console.Write("Enter your First Name:");
        string firstName = Console.ReadLine();
        Console.Write("Enter your Last Name:");
        string lastName = Console.ReadLine();
        Console.Write("Enter your Age:");
        byte age;
        string gender;
        string male = "male";
        string female = "female";
        int idNumber;
        int uniqueEmployeeNumber;
        do
        {
            age = byte.Parse(Console.ReadLine());
            if ((age < 18) || (age > 65))
            {
                Console.WriteLine("The age you have entered is incorrect.");
                Console.Write("Age:");
            }
        } while ((age < 18) || (age > 65));
        Console.WriteLine("Enter Gender (male or female):");
        do
        {
            gender = Console.ReadLine();
            if ((gender != male) && (gender != female))
            {
                Console.WriteLine("The gender you have entered is incorrect.");
                Console.Write("Gender:");
            }
        } while ((gender != male) && (gender != female));
        Console.WriteLine("Enter ID number (101 to 1001):");
        do
        {
            idNumber = int.Parse(Console.ReadLine());
            if ((idNumber < 101) || (idNumber > 1001))
            {
                Console.WriteLine("The ID number you have entered is incorrect.");
                Console.Write("ID number:");
            }
        } while ((idNumber < 101) || (idNumber > 1001));
        Console.WriteLine("Enter Employee number (27560000 to 27569999):");
        do
        {
            uniqueEmployeeNumber = int.Parse(Console.ReadLine());
            if ((uniqueEmployeeNumber < 27560000) || (uniqueEmployeeNumber > 27569999))
            {
                Console.WriteLine("The Employee number you have entered is incorrect.");
                Console.Write("ID number:");
            }
        } while ((uniqueEmployeeNumber < 27560000) || (uniqueEmployeeNumber > 27569999));

        Console.WriteLine("\nYour name is: {0}\nYour Age is: {1}\nYour Gender is: {2}\nYour ID number is: {3}\nYour Employee number is: {4}\n", firstName + " " + lastName, age, gender, idNumber, uniqueEmployeeNumber);
    }
}