using System;

namespace Print1toN
{
    class Print1toN
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            string nValue = Console.ReadLine();
            int n = int.Parse(nValue);
            for (int counter = 1; counter <= n; counter++)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
