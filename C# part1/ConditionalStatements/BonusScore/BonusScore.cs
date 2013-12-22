/*(TASK 10) Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.*/

using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter digit 1 to 9: ");
                string strEntered = Console.ReadLine();
                short digit;
                bool isNumber = short.TryParse(strEntered, out digit); //try to parse string 

                if (isNumber) //check the result is it true
                {

                    switch (digit)
                    {
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("OUTPUT: ");
                            Console.WriteLine(digit * 10);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Console.Write("OUTPUT: ");
                            Console.WriteLine(digit * 100);
                            break;
                        case 7:
                        case 8:
                        case 9:
                            Console.Write("OUTPUT: ");
                            Console.WriteLine(digit * 1000);
                            break;
                        default:
                            Console.WriteLine("I EXPECT DIGIT 1 TO 9"); // Msg if it is not a digit [1..9]
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("INCORRECT INPUT!"); // Msg for inccorect input
                }
            }
        }
    }
}