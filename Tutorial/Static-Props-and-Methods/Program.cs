public class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

internal partial class Program
{
    private static void Main(string[] args)
    {
        int a = 2, b= 3;

        Calculator calc = new Calculator();
        Console.WriteLine(calc.Sum(a, b));

        Console.WriteLine(Calculator.Multiply(a, b));
    }
}