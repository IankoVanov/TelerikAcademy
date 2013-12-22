//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

namespace PrintNotDivisible
{
    class PrintNotDivisible
    {
        static void Main()
        {
            Console.Write("Enter value for N: ");
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i < numN; i++)
            {
                if (!(i % (3 * 7) == 0)) //check both dividers
                {
                    Console.WriteLine(i); //print result
                }
            }
        }
    }
}











