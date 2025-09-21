using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class ArithmeticOperations
    {
        public static void ArithmeticExamples()
        {
            // Numbers, Integers and Math
            //int a = 18;
            //int b = 6;

            // long data type with explicit conversion
            //int a = 2100000000;
            //int b = 2100000000;
            //long c = (long)a + (long)b; // explicitly telling C# compiler to use long data type arithmetic for addition otherwise compiler will use int arithmetic
            //Console.WriteLine(c);

            // checked() will throw exception at runtime
            //int a = 2100000000;
            //int b = 2100000000;
            //long c = checked(a + b);
            //Console.WriteLine(c);

            // explicit conversion example
            //int a = (int)42.1;
            //int b = (int)38.2;
            //long c = checked(a + b); // 80.30000000000001 changed to 80 because of explicit int conversion
            //Console.WriteLine(c);

            /*
             *  C# gives Multiplication and Division precedence over addition and subtraction
             *  
             *  In a way C# follows BODMAS rule
             */
            // addition
            //Console.WriteLine("---Addition---");
            //int a = 10;
            //int b = 5;
            //int c = a + b;
            //Console.WriteLine($"a :- {a}");
            //Console.WriteLine($"b :- {b}");
            //Console.WriteLine($"result :- {c}");

            // subtraction
            //Console.WriteLine("---Subtraction---");
            //int a = 10;
            //int b = 5;
            //int c = a - b;
            //Console.WriteLine($"a :- {a}");
            //Console.WriteLine($"b :- {b}");
            //Console.WriteLine($"result :- {c}");

            // multiplication
            //Console.WriteLine("---Multiplication---");
            //int a = 10;
            //int b = 5;
            //int c = a * b;
            //Console.WriteLine($"a :- {a}");
            //Console.WriteLine($"b :- {b}");
            //Console.WriteLine($"result :- {c}");

            // Division (takes the quotient as answer)
            //Console.WriteLine("---Division---");
            //int a = 10;
            //int b = 5;
            //int c = a / b;
            //Console.WriteLine($"a :- {a}");
            //Console.WriteLine($"b :- {b}");
            //Console.WriteLine($"result :- {c}");


            // Modulus (takes the remainder as answer)
            //Console.WriteLine("---Modulus---");
            //int a = 10;
            //int b = 5;
            //int c = a % b;
            //Console.WriteLine($"a :- {a}");
            //Console.WriteLine($"b :- {b}");
            //Console.WriteLine($"result :- {c}");

            // Operator precedence example
            //int a = 5;
            //int b = 4;
            //int c = 2;
            ////int d = a + b * c;
            //int d = (a + b) * c; // Parenthesis around the addition operation gives it precedence
            //Console.WriteLine($"Operator precedence example result :- {d}");


            // Maximum and minimum limits of C# integer
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} and {max}");
        }
    }
}
