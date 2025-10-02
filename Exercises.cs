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
            List<int> numbersDivisibleBy3 = [];
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    numbersDivisibleBy3.Add(i);
                }
            }
            Console.Write($"Numbers divisble by 3 between 1 to 20 are as follows:- ");
            foreach (var item in numbersDivisibleBy3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nThe count of numbers divisible by 3 between 1 to 20 is {numbersDivisibleBy3.Count}");
            Console.WriteLine($"The sum of all integers from 1 to 20 that are divisible by 3 is :- {sum}");
        }
        public static int addTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static List<int> fibonacciSeriesTill20() 
        {
            int num1 = 1;
            int num2 = 1;
            int result;

            List<int> fibSeries = [num1, num2];

            for (int i = 3; i <= 20; i++)
            {
                result = num1 + num2;
                fibSeries.Add(result);
                num1 = num2;
                num2 = result;
            }

            return fibSeries;
        }
    }
}
