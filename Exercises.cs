using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Exercises
    {
        public static void Sumof1to20NumbersDivisibleBy3()
        {
            // sum of all integers from 1 to 20 that are divisible by 3
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all integers from 1 to 20 that are divisible by 3 is :- {sum}");
        }
        public static int addTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
