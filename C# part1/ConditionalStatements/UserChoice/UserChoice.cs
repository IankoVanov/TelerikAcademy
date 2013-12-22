/* (TASK 8) Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement. */

using System;

namespace UserChoice
{
    class UserChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enetr digit to submit your choice: ");
            Console.WriteLine("INTEGER (1), DOUBLE(2), STRING(3)");
            while (true)
            {
                Console.Write("CHOICE IS: ");
                sbyte choice = sbyte.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1: Console.WriteLine("You selected the INTEGER.");
                        Console.Write("Enter Value: ");
                        int intValue = int.Parse(Console.ReadLine());
                        Console.Write("OUTPUT: ");
                        Console.WriteLine(intValue + 1);
                        break;

                    case 2: Console.WriteLine("You selected the DOUBLE.");
                        Console.Write("Enter Value: ");
                        double dblVal = double.Parse(Console.ReadLine());
                        Console.Write("OUTPUT: ");
                        Console.WriteLine(dblVal + 1);
                        break;

                    case 3: Console.WriteLine("You selected the STRING.");
                        Console.Write("Enter Value: ");
                        string strText = Console.ReadLine();
                        Console.Write("OUTPUT: ");
                        Console.WriteLine(strText + "*");
                        break;
                    default: Console.WriteLine("PLEASE ENETR NUMBER 1 TO 3");
                        break;
                }
            }
        }
    }
}