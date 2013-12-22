//(TASK 7) Write a program that finds the greatest of given 5 variables.


using System;

namespace FindGreatestNum
{
    class FindGreatestNum
    {
        static void Main()
        {
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("D: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("E: ");
            int e = int.Parse(Console.ReadLine());
            int biggestNum = a;

            if (biggestNum < b)
            {
                biggestNum = b;
            }
            if (biggestNum < c)
            {
                biggestNum = c;
            }
            if (biggestNum < d)
            {
                biggestNum = d;
            }
            if (biggestNum < e)
            {
                biggestNum = e;
            }
            Console.WriteLine("Bigest Number is {0}", biggestNum);
        }
    }
}
