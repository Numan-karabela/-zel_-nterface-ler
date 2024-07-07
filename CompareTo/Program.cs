Person person1 = new Person() { Name = "Mehmet", Age = 28 };
Person person2 = new Person() { Name = "Temel", Age = 25 };


Console.WriteLine(person1.CompareTo(person2));

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person? other)
    {
        return other.Age.CompareTo(Age);
    }
}