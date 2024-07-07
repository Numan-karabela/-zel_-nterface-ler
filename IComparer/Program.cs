using System.Threading.Channels;


Person person1 = new Person() { Name = "Numan", Age = 20 };
Person person2 = new Person() { Name = "Ahmet", Age = 10 };
Person person3 = new Person() { Name = "Mehmet", Age = 28 };
Person person4 = new Person() { Name = "Temel", Age = 25 };

List<Person> ListPerson = new List<Person>() { person1, person2, person3, person4 };

ListPerson.Sort(new AgeCompare());
ListPerson.ForEach(p => Console.WriteLine(p.Name));



AgeCompare ageCompare = new();
var result = ageCompare.Compare(person1, person2);

Console.WriteLine(result);

class AgeCompare : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Age.CompareTo(y.Age);
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}