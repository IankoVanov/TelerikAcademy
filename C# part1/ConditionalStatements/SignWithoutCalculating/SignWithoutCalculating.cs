/* (TASK 2) Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.*/


using System;

namespace SignWithoutCalculating
{
    class SignWithoutCalculating
    {
        static void Main()
        {
            Console.WriteLine("Please enter three values: ");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product of these three vlues is 0");
            }
            else
            {
                bool sign = true;
                if (a < 0)
                {
                    sign = !sign;
                }
                if (b < 0)
                {
                    sign = !sign;
                }
                if (c < 0)
                {
                    sign = !sign;
                }
                Console.WriteLine("The product of these three values is with sign ({0})", sign ? "+" : "-");
            }
        }
    }
}
