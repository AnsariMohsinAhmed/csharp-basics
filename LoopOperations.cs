using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class LoopOperations
    {
        public static void LoopExamples()
        {
            // Loops

            // While loop
            Console.WriteLine("while loop example");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello! The counter is {counter}");
                counter++;
            }

            // do-while loop

            //Console.WriteLine("do-while loop example");
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine($"Hello! The counter is {counter}");
            //    counter++;
            //} while (counter < 10);


            // for loop
            // for(for initializer; for condition; for iterator)
            // for(int i = 0; i < 10; i++)

            //Console.WriteLine("for loop example");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Hello! The counter is {i}");
            //}
        }
    }
}
