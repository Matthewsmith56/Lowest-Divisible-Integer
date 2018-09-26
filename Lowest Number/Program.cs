using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int[] numsArray = Enumerable.Range(1, 20).ToArray();

            for (int i = 2; i >= 0;)
            {
                if (i % numsArray[j] == 0)
                {
                    if (j == 19)
                    {
                        Console.WriteLine("The lowest integer Divisible by " +
                                          "numbers 1 - 20 without a remainder is " + i);
                        break;
                    }
                    j++;
                }
                else if (i % numsArray[j] != 0)
                {
                    j = 0;
                    i += 2;
                }
            }

        }
    }
}
