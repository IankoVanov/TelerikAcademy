using System;

namespace ExistingPNumers
{
    class ExistingPNumers
    {
        static void Main()
        {
            int a, b, count = 0;
            Console.Write("Enter num a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num b:");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                    count++;
            }
            Console.WriteLine("The numbers between {0} and {1} that can divide with five are {2}", a, b, count);
        }
    }
}
