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
//Exercises.Sumof1to20NumbersDivisibleBy3();

// List
//ListExercise.ListExercises();

//List<int> result = Exercises.fibonacciSeriesTill20();
//Console.Write("The fibonacci series till 20 is as follows :- ");
//foreach (var item in result)
//{
//    Console.Write($"{item}, ");
//}

// LINQ

//LINQOperations.LINQExamples();
int[] scores = [55, 44, 84, 30];
Console.WriteLine("Scores array is below:- ");
foreach (int item in scores)
{
    Console.Write($"{item}, ");
}
List<int> result =  LINQOperations.GetScoresGreaterThan50(scores);
Console.WriteLine($"\nScores greater than 50 are :- ");
foreach (int item in result)
{
    Console.Write($"{item} ");
}