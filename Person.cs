using ValueObjectsDemo.ValueObjects;

namespace ValueObjectsDemo;

internal class Person
{
    public Nif Nif { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public CP CP { get; set; } = default!;

    public override string ToString()
    {
        return $"{Nif.Value} {Name} {LastName} {CP.Value}";
    }
}

