using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectsDemo.DomainExceptions
{
    internal class InvalidNifException : Exception
    {
        public InvalidNifException(string nif) : base($"The nif is invalid: {nif}.")
        { }
    }
}
