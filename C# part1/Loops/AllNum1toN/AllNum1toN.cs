//Write a program that prints all the numbers from 1 to N.

using System;

namespace AllNum1toN
{
    class AllNum1toN
    {
        static void Main()
        {
            Console.Write("Enter value for N: ");
            int numN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
