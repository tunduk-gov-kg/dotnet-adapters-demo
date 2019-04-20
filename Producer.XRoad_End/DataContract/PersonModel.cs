using System;
using System.IO;
using System.Xml.Serialization;
using Producer.Data;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace Producer.XRoad_End.DataContract
{
    [XmlType(TypeName = "Person", Namespace = "http://producer.xroad.com")]
    public class PersonModel : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Pin", IsOptional = false, Order = 0)]
        public string Pin { get; set; }
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 1)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "BirthDate", IsOptional = false, Order = 2)]
        public DateTime BirthDate { get; set; }
        [XRoadXmlElement(ElementName = "Gender", IsOptional = false, Order = 3)]
        public GenderEnum Gender { get; set; }
        [XRoadXmlElement(ElementName = "Photo", IsOptional = false, Order = 4)]
        public Stream Photo { get; set; }
    }
}
