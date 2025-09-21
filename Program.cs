// See https://aka.ms/new-console-template for more information
// Strings
// Strings are immutable in .NET
using helloworld;

Console.WriteLine("Hello Mohsin!");

// String operation examples
//StringOperations.StringExamples();

/* ----------------------- BREAK -----------------------  */

// Arithmetic operation examples
//ArithmeticOperations.ArithmeticExamples();

// branching
//BranchingOperations.BranchingExamples();


// Loops
//LoopOperations.LoopExamples();

// exercise
// sum of all integers from 1 to 20 that are divisible by 3
Exercises.Sumof1to20NumbersDivisibleBy3();
Console.WriteLine("Enter num1:- ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num2 :- ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Exercises.addTwoNumbers(num1, num2);
Console.WriteLine($"Addition of {num1} and {num2} is {result}");