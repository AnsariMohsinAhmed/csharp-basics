// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Mohsin!");

string firstFriend = "Adnan";
firstFriend = firstFriend.Trim();
string secondFriend = "Kutbuddin";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";
Console.WriteLine(friends.Replace("Kutbuddin", "Saad")); // string interpolation

// Console.WriteLine("My friends are " +  firstFriend + " and " + secondFriend); // concatenation
