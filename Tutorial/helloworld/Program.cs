// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Microsoft!");

// Trimming spaces in strings
string firstFriend = "James";
string secondFriend = "    Monroe     ";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend.Trim()}.");
Console.WriteLine();

// Replacing parts of a string, i.e. strings are immutable, thr original string is not changed
string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}.";
string new_friends = friends.Replace("James", "Lincoln");
Console.WriteLine(friends);
Console.WriteLine(new_friends);
Console.WriteLine();

// Checking if a string contains given characters of phrases
Console.WriteLine(friends.Contains("Woodrow"));
Console.WriteLine(new_friends.Contains("Lincoln"));
Console.WriteLine();

// ToUpper and ToLower
Console.WriteLine(friends.ToUpper());
Console.WriteLine(new_friends.ToLower());
Console.WriteLine();

// Get the length of a string
Console.WriteLine(friends.Length);
Console.WriteLine();

// startswith and endswith
Console.WriteLine(friends.StartsWith("My"));
Console.WriteLine(new_friends.EndsWith("roe"));
Console.WriteLine();
