using System.Xml.Serialization;

namespace Producer.Data
{
    [XmlType(TypeName = "Gender", Namespace = "http://producer.data.com")]
    public enum Gender
    {
        Male = 1,
        Female = 0
    }
}