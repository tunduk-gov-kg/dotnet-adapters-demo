using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consumer.XRoad_End.XRoad.Producer;

namespace Consumer.XRoad_End
{
    class XRoadPersonDataManager : IPersonDataManager
    {
        public PersonData GetPersonData(string pin)
        {
            PortTypeNameClient client = new PortTypeNameClient();
            var getPersonRequest = new GetPersonRequest();
            getPersonRequest.id = Guid.NewGuid().ToString();
            getPersonRequest.userId = "Sample User id";
            getPersonRequest.issue = "Sample issue";
            getPersonRequest.protocolVersion = "4.0";
            getPersonRequest.client = new XRoadClientIdentifierType()
            {
                xRoadInstance = "",
                memberClass = "",
                memberCode = ""
            };
            getPersonRequest.service = new XRoadServiceIdentifierType()
            {
                xRoadInstance = "",
                memberClass = "",
                memberCode = "",
                serviceCode = "GetPerson",
                serviceVersion = "v1"
            };
            getPersonRequest.GetPerson = new GetPerson()
            {
                request = pin
            };

            GetPersonResponse1 response1 = client.GetPerson(getPersonRequest);
            var item = response1.GetPersonResponse.Item;
            if (item is fault)
            {
                throw new ApplicationException( (item as fault).faultString);
            }

            return ConvertToPersonData(item);
        }

        private PersonData ConvertToPersonData(object item)
        {
            var person = item as Person;
            return new PersonData()
            {
                Pin = person.Pin,
                BirthDate = person.BirthDate.ToShortDateString(),
                Gender = person.Gender.ToString(),
                Name = person.Name,
                Photo = new Bitmap(new MemoryStream(person.Photo))
            };
        }
    }
}
