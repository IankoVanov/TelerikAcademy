﻿//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

namespace DigitToText
{
    class DigitToText
    {
        static void Main()
        {
            while (true)
            {


                Console.WriteLine("Please enter digit to see its string representation: ");
                sbyte digit = sbyte.Parse(Console.ReadLine());

                switch (digit)
                {
                    case 0: Console.WriteLine("ZERO");
                        break;
                    case 1: Console.WriteLine("ONE");
                        break;
                    case 2: Console.WriteLine("TWO");
                        break;
                    case 3: Console.WriteLine("THREE");
                        break;
                    case 4: Console.WriteLine("FOUR");
                        break;
                    case 5: Console.WriteLine("FIVE");
                        break;
                    case 6: Console.WriteLine("SIX");
                        break;
                    case 7: Console.WriteLine("SEVEN");
                        break;
                    case 8: Console.WriteLine("EIGHT");
                        break;
                    case 9: Console.WriteLine("NINE");
                        break;
                    default: Console.WriteLine("!! SINGLE DIGIT PLEASE !!!");
                        break;
                }
            }
        }
    }
}
