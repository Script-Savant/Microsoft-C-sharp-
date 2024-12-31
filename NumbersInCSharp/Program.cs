// int a = 2100000000, b = 2100000000;
// long c = (long)a + (long)b; // Convert the integers to long to prevent an overflow
// long c = checked(a+b); // Generate an exception if there is an overflow
// Console.WriteLine(c);

// decimal, double, float

// int x = 5, y = 5, z = x + y;
// bool myTest = z > 10;

// if (myTest){
//     Console.WriteLine("Sum is greater than 10");
// } else {
//     Console.WriteLine("sum is equal or less than 10");
// }

// while loop
// int counter = 0;
// while (counter < 5){
//     Console.WriteLine(counter);
//     counter++;
// }

// for loop
// for (int i = 0; i < 5; i++) {
//     if (i == 3) {
//         Console.WriteLine("Three");
//     } else {
//         Console.WriteLine(i);
//     }
// }

// List T Collections of Data
var names = new List<string> {"Felipe", "James", "Monroe"};

names.Add("Corazon");
names.Add("Ernesto");
names.Add("Christian");

// Sort names
names.Sort();
// Reverse names
names.Reverse();
// Find the index of
Console.WriteLine($"Index of Corazon is {names.IndexOf("Corazon")}");

foreach (var name in names) 
{
    Console.WriteLine(name);
}

// Console.WriteLine(names[0]);
// Console.WriteLine(names[names.Count-1]); // Use count to get the last element of the list
// Console.WriteLine(names[^2]); // count from the back of the list

// Console.WriteLine();

// foreach (var name in names[2..4]){ // get a range from the list
//     Console.WriteLine(name);
// }

// var newNames = new string[] { "Edith", "Casemiro", "Mondragon" };
// // Add to an array
// newNames = [.. newNames, "Kairo"];
// foreach (var name in newNames)
// {
//     Console.WriteLine(name);
// }

