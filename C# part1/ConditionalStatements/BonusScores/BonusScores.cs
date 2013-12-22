using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit in the range [1..9]: ");
            string isString = Console.ReadLine();
            ushort intInput;
            bool isNumber = ushort.TryParse(isString, out intInput);

            if (isNumber)
            {
                switch (intInput)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine(intInput * 10);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine(intInput * 100);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine(intInput * 1000);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error! Incorrect input!");
            }
        }
    }
}
