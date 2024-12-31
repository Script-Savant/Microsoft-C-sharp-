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
for (int i = 0; i < 5; i++) {
    if (i == 3) {
        Console.WriteLine("Three");
    } else {
        Console.WriteLine(i);
    }
}
