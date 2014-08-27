using System;
//Write an expression that checks for given integer if its third digit 
//(right-to-left) is 7. E. g. 1732  true.


class CheckThirdDigits
{
    static void Main()
    {
        //int number = 1233722;
        //int newNumber = number / 100;
        //double compareNumber = (double)newNumber / 10;
        //int maskNumber = (int)compareNumber;        
        //Console.WriteLine(newNumber);
        //Console.WriteLine(compareNumber);
        //Console.WriteLine(maskNumber);
        //Console.WriteLine(125==125.1);
        //Console.WriteLine(compareNumber - 0.6 == maskNumber);



        Console.Title = "Chek for third digit is Sevem";
        //Console.Write("Enter number: ");
        //double chekNumber = double.Parse(Console.ReadLine());       
        //int firstMaskNumber = (int)chekNumber / 100;
        //double secondMaskNumber = (double)firstMaskNumber / 10;
        //int thirdMaskNumber = (int)secondMaskNumber;
        //if (secondMaskNumber - 0.7 == thirdMaskNumber)
        //{
        //    Console.WriteLine("Third gigits is 7");
        //}
        //else
        //    Console.WriteLine("Third digits is not 7");


        //Other metod
        //Console.Write("Enter number: ");
        //int chekNum = int.Parse(Console.ReadLine());
        //chekNum /= 100;
        //Console.WriteLine(chekNum);
        //chekNum %= 10;
        //Console.WriteLine(chekNum);
        //if (chekNum == 7)
        //{
        //    Console.WriteLine("Third gigits is 7");
        //}
        //else
        //    Console.WriteLine("Third digits is not 7");

        //Other metod
        Console.Write("Enter number: ");
        string chekNum = Console.ReadLine();
        char chekNumChar = (char)chekNum[3];
        Console.WriteLine((char)chekNum[3]);
        Console.WriteLine(chekNumChar);

        if ((char)chekNum[3] == '7')
        {
            Console.WriteLine("third gigits is 7");
        }
        else
            Console.WriteLine("third digits is not 7");


    }
}