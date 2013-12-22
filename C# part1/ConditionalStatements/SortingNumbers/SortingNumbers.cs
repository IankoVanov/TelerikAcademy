//(TASK 4) Sort 3 real values in descending order using nested if statements.

using System;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter three values to be sorted in descending order: ");
                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());

                if (a >= b && a >= c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("Order is {0},{1},{2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("Order is {0},{1},{2}", a, c, b);
                    }
                }
                else if (b >= a && b >= c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("Order is {0},{1},{2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("Order is {0},{1},{2}", b, c, a);
                    }
                }
                else
                {
                    if (a > b)
                    {
                        Console.WriteLine("Order is {0},{1},{2}", c, a, b);
                    }
                    else
                    {
                        Console.WriteLine("Order is {0},{1},{2}", c, b, a);
                    }
                }
            }
        }
    }
}
