// (TASK 3) Write a program that finds the biggest of three integers using nested if statements.

using System;

namespace FindBiggestNum
{
    class FindBiggestNum
    {
        static void Main()
        {
            Console.WriteLine("Please enter three values to be compared: ");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Biggest number is A ({0})", a);
                }
                else
                {
                    Console.WriteLine("Biggest number is C ({0})", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Biggest number is B ({0})", b);
                }
                else
                {
                    Console.WriteLine("Biggest number is C ({0})", c);
                }
            }
        }
    }
}
