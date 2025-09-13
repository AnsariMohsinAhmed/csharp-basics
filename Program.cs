// See https://aka.ms/new-console-template for more information
// Strings
// Strings are immutable in .NET
Console.WriteLine("Hello Mohsin!");

string firstFriend = "Adnan";
firstFriend = firstFriend.Trim();
string secondFriend = "Kutbuddin";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}"; // string interpolation
Console.WriteLine(friends);
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
int a = (int)42.1;
int b = (int)38.2;
long c = checked(a + b); // 80.30000000000001 changed to 80 because of explicit int conversion
Console.WriteLine(c);
