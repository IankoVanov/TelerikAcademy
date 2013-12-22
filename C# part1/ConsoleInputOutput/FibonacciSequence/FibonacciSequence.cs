using System;

namespace FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main()
        {
            decimal member1 = 0;
            decimal member2 = 1;
            for (int counter = 0; counter < 100; counter++)
            {
                Console.WriteLine(member1);
                decimal sum = member1 + member2;
                member1 = member2;
                member2 = sum;
            }
        }
    }
}
