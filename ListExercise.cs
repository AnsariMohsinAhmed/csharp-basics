using System;

namespace helloworld;

// List<T> it is pronounced as "List of T"
internal class ListExercise
{
	public static void ListExercises()
	{
		List<string> names = ["Arthur", "Ana", "Felipe"];

		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name}!");
		}

		// access items by their index

		//Console.WriteLine($"The first element is {names[0]}");

		// Length of the List

		Console.WriteLine($"The number of persons in the List is {names.Count}");

		// add object at the end of List<string>
		//names.Add("Roger");
		//names.Add("Clark");
		//Console.WriteLine("After adding some names");

		// Removing an object from the List<string>
		//names.Remove("Felipe");
		//Console.WriteLine("After removing Felipe");

		// Search

		int index = names.IndexOf("Felipe");
		if (index == -1)
		{
			Console.WriteLine($"Item not found in the List");
		}
		else {
			Console.WriteLine($"Item found at index {index}");
		}
    }
}
