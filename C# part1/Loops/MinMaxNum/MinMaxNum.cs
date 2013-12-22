//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

namespace MinMaxNum
{
    class MinMaxNum
    {
        static void Main()
        {
            int numN = int.Parse(Console.ReadLine());
            int curNum = int.Parse(Console.ReadLine());
            int minVal = curNum;
            int maxVal = curNum;

            for (int i = 1; i < numN; i++)
            {
                curNum = int.Parse(Console.ReadLine());

                if (minVal > curNum)
                {
                    minVal = curNum;
                }

                if (maxVal < curNum)
                {
                    maxVal = curNum;
                }
            }

            Console.WriteLine("Min ({0}), Max ({1})", minVal, maxVal);
        }
    }
}
