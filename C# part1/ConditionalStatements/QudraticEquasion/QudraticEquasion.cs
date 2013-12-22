/*(TASK 6) Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots. */


using System;

namespace QudraticEquasion
{
    class QudraticEquasion
    {
        static void Main()
        {

            Console.WriteLine("Please enetr a, b, c of quadratic equasion ax2 + bx + c = 0 : ");
            while (true)
            {
                Console.Write("a: ");
                double a = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Please enter value for \'a\' different from 0 !"); // Check if value a=0
                    continue;
                }

                Console.Write("b: ");
                double b = int.Parse(Console.ReadLine());

                Console.Write("c: ");
                double c = int.Parse(Console.ReadLine());

                double x1;
                double x2;

                double D;

                D = (b * b) - 4 * a * c;

                if (D < 0)
                {
                    Console.WriteLine("Equasion has no real roots");
                }
                else if (D == 0)
                {
                    Console.WriteLine("Equasion have one real root");
                    x1 = -b / 2 * a;
                    Console.WriteLine("x1 = {0}", x1);
                }
                else
                {
                    Console.WriteLine("Equasion have two real roots:");
                    x1 = (-b - Math.Sqrt(D)) / 2 * a;
                    x2 = (-b + Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                }

            }
        }
    }
}