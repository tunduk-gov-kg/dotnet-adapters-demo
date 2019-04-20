using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Producer.Data;
using Producer.Service;
using Producer.XRoad_End.DataContract;

namespace Producer.XRoad_End.ServiceContract
{
    public class PersonSoapService : IPersonSoapService, IDisposable
    {
        private readonly IPersonService _personService;

        public PersonSoapService(IPersonService personService)
        {
            _personService = personService;
        }

        public PersonModel GetPerson(string pin)
        {
            var person = _personService.GetPerson(pin);
            return person == null ? null : ConvertToModel(person);
        }

        public void Dispose()
        {
            _personService.Dispose();
        }

        private PersonModel ConvertToModel(Person person)
        {
            return new PersonModel()
            {
                Pin = person.Pin,
                Name = person.Name,
                Gender = (GenderEnum) person.Gender,
                BirthDate = person.BirthDate,
                Photo = new MemoryStream(person.Photo)
            };
        }
    }
}
