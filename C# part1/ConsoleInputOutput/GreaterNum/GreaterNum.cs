using System;

namespace GreaterNum
{
    class GreaterNum
    {
        static void Main()
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The greater number of {0} and {1} is {2}", num1, num2, num1 > num2 ? num1 : num2);
        }
    }
}
