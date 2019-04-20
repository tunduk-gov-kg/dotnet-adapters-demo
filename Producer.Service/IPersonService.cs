using Producer.Data;
using System;

namespace Producer.Service
{
    public interface IPersonService : IDisposable
    {
        Person GetPerson(string pin);
    }
}
