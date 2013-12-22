/*(TASK 11) 
 * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 -> "Zero"
	273 -> "Two hundred seventy three"
	400 -> "Four hundred"
	501 -> "Five hundred and one"
	711 -> "Seven hundred and eleven" */

using System;

namespace NumberToText
{
    class NumberToText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in range [0..999]");

            string[] firstDigitStr = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] secondDigitStr = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] specialDigitStr = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            int numIn;

            do
            {
                Console.Write("NUM: ");
                numIn = int.Parse(Console.ReadLine());

            } while (numIn < 0 || numIn > 999);

            int firstDigit = numIn % 10;
            numIn /= 10;
            int counter = 1;
            int seconDigit = 0;
            int thirdDigit = 0;

            if ((numIn + 9) / 10 != 0)
            {
                seconDigit = numIn % 10;
                numIn /= 10;
                counter++;
            }
            if ((numIn + 9) / 10 != 0)
            {
                thirdDigit = numIn % 10;
                numIn /= 10;
                counter++;
            }
            if (counter == 1)
            {
                if (counter == 0)
                {
                    Console.WriteLine("zero");
                }
                else
                {
                    Console.WriteLine(firstDigitStr[firstDigit]);
                }
            }
            if (counter == 2)
            {
                if (seconDigit == 1)
                {
                    Console.WriteLine(specialDigitStr[firstDigit]);
                }
                else
                {
                    Console.WriteLine("{0} {1}", secondDigitStr[seconDigit], firstDigitStr[firstDigit]);
                }
            }
            if (counter == 3)
            {
                if (seconDigit == 1)
                {
                    Console.WriteLine("{0} hundred and {1}", firstDigitStr[thirdDigit], specialDigitStr[firstDigit]);
                }
                else if (firstDigit == 0 && seconDigit == 0)
                {
                    Console.WriteLine("{0} hundred", firstDigitStr[thirdDigit]);
                }
                else
                {
                    Console.WriteLine("{0} hunred and {1} {2}", firstDigitStr[thirdDigit], secondDigitStr[seconDigit], firstDigitStr[firstDigit]);
                }

            }
        }
    }
}