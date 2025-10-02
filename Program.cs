// See https://aka.ms/new-console-template for more information
// Strings
// Strings are immutable in .NET
using helloworld;

//Console.WriteLine("Hello Mohsin!");

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

// List
//ListExercise.ListExercises();

List<int> result = Exercises.fibonacciSeriesTill20();
Console.Write("The fibonacci series till 20 is as follows :- ");
foreach (var item in result)
{
    Console.Write($"{item}, ");
}