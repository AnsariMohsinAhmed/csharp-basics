using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class BranchingOperations
    {
        public static void BranchingExamples()
        {
            // branching

            // Basic
            int a = 5;
            int b = 2;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            // Logical AND &&
            // == tests for equality

            //int a = 5;
            //int b = 5;
            //int c = 4;
            //if ((a + b + c > 10) && (a == b))
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("The first number a is equal to second number b");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("Or the first number is not equal to the second");
            //}


            // Logical OR ||

            //int a = 5;
            //int b = 2;
            //int c = 4;
            //if ((a + b + c > 10) || (a == b))
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("The first number a is equal to second number b");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("Or the first number is not equal to the second");
            //}
        }
    }
}
