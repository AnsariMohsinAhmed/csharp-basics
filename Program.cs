// See https://aka.ms/new-console-template for more information
// Strings
// Strings are immutable in .NET
Console.WriteLine("Hello Mohsin!");

//string firstFriend = "Adnan";
//firstFriend = firstFriend.Trim();
//string secondFriend = "Kutbuddin";

//string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}"; // string interpolation
//Console.WriteLine(friends);
//Console.WriteLine(friends.Contains("Kutbuddin"));
//Console.WriteLine($"Length of friends string :- {friends.Length}");
//Console.WriteLine(friends.StartsWith("My"));
//friends = friends.Replace("Kutbuddin", "Saad"); // Explicitly assigning new values to 'friends' string

// Console.WriteLine("My friends are " +  firstFriend + " and " + secondFriend); // concatenation

/* ----------------------- BREAK -----------------------  */

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
//int max = int.MaxValue;
//int min = int.MinValue;
//Console.WriteLine($"The range of integers is {min} and {max}");

// branching

// Basic
//int a = 5;
//int b = 2;
//if (a + b > 10)
//{
//    Console.WriteLine("The answer is greater than 10");
//}
//else
//{
//    Console.WriteLine("The answer is not greater than 10");
//}

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


// Loops

// While loop
//Console.WriteLine("while loop example");
//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello! The counter is {counter}");
//    counter++;
//}

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

// exercise
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