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


// Numbers, Integers and Math
//int a = 18;
//int b = 6;
int a = 2100000000;
int b = 2100000000;
long c = checked(a + b);
Console.WriteLine(c);
