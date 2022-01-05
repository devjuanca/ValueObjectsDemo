using ValueObjectsDemo;
using ValueObjectsDemo.ValueObjects;
using ValueOf;

try
{
    Person invalid_person = new()
    {
        Nif = Nif.From("5454545"),
        Name = "John",
        LastName = "Smith",
        CP = CP.From("52412")

    };
    Console.WriteLine(invalid_person.ToString());


}
catch (Exception ex)
{ Console.WriteLine(ex.Message); }

Person valid_person = new()
{
    Nif = Nif.From("12345678A"),
    Name = "John",
    LastName = "Smith",
    CP = CP.From("52412")

};
Console.WriteLine(valid_person.ToString());



Console.ReadLine();
