public class Person
{
    public static int PopulationCounter { get; set; } = 0;
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
        PopulationCounter++;
    }
}

internal partial class Program
{
    private static void Main(string[] args)
    {
        Person p1 = new("Saldina");
        Person p2 = new("Joe");
        Person p3 = new("Emiliano");

        Console.WriteLine(p1.Name);
        Console.WriteLine(Person.PopulationCounter);
    }
}