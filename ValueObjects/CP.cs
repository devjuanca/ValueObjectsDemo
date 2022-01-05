using ValueObjectsDemo.DomainExceptions;
using ValueOf;

namespace ValueObjectsDemo.ValueObjects
{
    internal class CP : ValueOf<string, CP>
    {
        protected override void Validate()
        {
            if (!int.TryParse(Value, out _))
                throw new InvalidCPException(Value!);
        }
    }
}
