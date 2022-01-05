namespace ValueObjectsDemo.DomainExceptions;

internal class InvalidCPException : Exception
{
    public InvalidCPException(string cp) : base($"The CP is invalid: {cp}.")
    { }
}

