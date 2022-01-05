using ValueObjectsDemo.DomainExceptions;
using ValueOf;

namespace ValueObjectsDemo.ValueObjects;

internal class Nif : ValueOf<string, Nif>
{
    protected override void Validate()
    {
        if (Value.Length != 9 || Value?.Last() is not char)
            throw new InvalidNifException(Value!);
    }
}

