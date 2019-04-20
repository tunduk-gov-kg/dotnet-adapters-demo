using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using XRoadLib;
using XRoadLib.Headers;
using XRoadLib.Schema;

namespace Producer.XRoad_End
{
    public class PersonSoapServiceManager : ServiceManager<XRoadHeader40>
    {
        public PersonSoapServiceManager() 
            : base("4.0", new DefaultSchemaExporter("http://producer.xroad.com",
                typeof(PersonSoapServiceManager).GetTypeInfo().Assembly))
        {
        }
    }
}
