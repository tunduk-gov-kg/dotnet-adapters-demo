using Producer.XRoad_End.DataContract;
using XRoadLib.Attributes;

namespace Producer.XRoad_End.ServiceContract
{
    public interface IPersonSoapService
    {
        [XRoadService("GetPerson", AddedInVersion = 1)]
        [XRoadTitle("RU","Сервис для выдачи персональных данных по пин")]
        PersonModel GetPerson(string pin);
    }
}
