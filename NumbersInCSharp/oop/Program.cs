var p1 = new Person("James", "Monroe", new DateOnly(1820, 1, 1));
var p2 = new Person("Sara", "Maldonado", new DateOnly(1980, 3, 10));

p1.Pets.Add(new Dog("Jesus"));
p1.Pets.Add(new Dog("Maria"));

p2.Pets.Add(new Cat("Lucky"));

List<Person> people = [p1, p2];


foreach (var person in people)
{
    Console.WriteLine(person.ToString());
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"     {pet.ToString()}");
    }
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public DateOnly Birthday { get; } = birthday;
    public List<Pet> Pets { get; } = new();
    public override string ToString(){
        return $"{First} {Last}";
    }
}

public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;
    public abstract string MakeNoise();
    public override string ToString()
    {
        return $"{First}, and I am a {GetType().Name} and I {MakeNoise()}";
    }
}

public class Cat(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "meow";
}

public class Dog(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "bark";
}