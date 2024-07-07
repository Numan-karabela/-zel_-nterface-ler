using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

Person p = new() { Name = "Numan" };

p.PropertyChanged += (sender, e) =>
{
    Console.WriteLine($"{e.PropertyName} propertisinin değeri {{{(sender as Person)?.Age}}} olarak değiştirilmiştir");
};
p.Age = 10;
p.Age = 20;
p.Age = 23;

public class Person : INotifyPropertyChanged
{
    public string Name { get; set; }
    int age;

    public int Age
    {
        get { return age; }
        set
        {
            age = value;
            PropertyChanged(this, new(nameof(Age)));
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;
}