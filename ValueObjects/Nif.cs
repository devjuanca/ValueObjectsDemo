using ValueObjectsDemo.DomainExceptions;
using ValueOf;

namespace ValueObjectsDemo.ValueObjects;

internal class Nif : ValueOf<string, Nif>
{
    protected override void Validate()
    {
        if (Value.Length != 9 || !char.IsLetter(Value.Last()))
            throw new InvalidNifException(Value!);
    }
}

