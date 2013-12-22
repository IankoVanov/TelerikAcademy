/*(TASK 9) We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0. */


using System;

namespace CheckTheSum
{
    class CheckTheSum
    {
        static void Main()
        {
            Console.WriteLine("Please enter five values: ");
            int[] number = new int[5];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            int result = 0;
            int count = 0;

            for (int i = 0; i < number.Length; i++)
            {


                for (int j = i + 1; j < number.Length; j++)
                {
                    result = number[i] + number[j];
                    if (result == 0)
                    {
                        count++;
                    }
                    Console.WriteLine("{0} + {1} = {2}", number[i], number[j], result);
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        result = result + number[k];
                        if (result == 0)
                        {
                            count++;
                        }
                        Console.WriteLine("{0} + {1} + {2} = {3}", number[i], number[j], number[k], result);
                        for (int l = k + 1; l < number.Length; l++)
                        {
                            result = result + number[l];
                            if (result == 0)
                            {
                                count++;
                            }
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", number[i], number[j], number[k], number[l], result);
                            for (int m = l + 1; m < number.Length; m++)
                            {
                                result = result + number[m];
                                if (result == 0)
                                {
                                    count++;
                                }
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", number[i], number[j], number[k],
                                    number[l], number[m], result);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("There are {0} results that subset of them is 0", count);
        }
    }
}
    
