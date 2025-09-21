using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class StringOperations
    {
        public static void StringExamples()
        {
            string firstFriend = "Adnan";
            firstFriend = firstFriend.Trim();
            string secondFriend = "Kutbuddin";

            string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}"; // string interpolation
            Console.WriteLine(friends);
            Console.WriteLine(friends.Contains("Kutbuddin"));
            Console.WriteLine($"Length of friends string :- {friends.Length}");
            Console.WriteLine(friends.StartsWith("My"));
            friends = friends.Replace("Kutbuddin", "Saad"); // Explicitly assigning new values to 'friends' string

            Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend); // concatenation
        }
    }
}
