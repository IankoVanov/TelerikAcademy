/*(TASK 1)Write an if statement that examines two integer variables and exchanges their 
 * values if the first one is greater than the second one.*/


using System;

namespace ExchangeValuesIf
{
    class ExchangeValuesIf
    {
        static void Main()
        {
            Console.WriteLine("Please enter two values to be compared: ");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            if (a > b)
            {
                Console.WriteLine("A={0} is bigger than B={1}", a, b);
                a = b;
                b = c;
                Console.WriteLine("And now A={0} and B={1}", a, b);
            }
            else
            {
                Console.WriteLine("A={0} is smaller than B={1}", a, b);
            }
        }
    }
}
