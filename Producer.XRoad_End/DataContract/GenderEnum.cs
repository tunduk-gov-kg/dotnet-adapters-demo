using System.Xml.Serialization;

namespace Producer.XRoad_End.DataContract
{
    [XmlType(TypeName = "Gender")]
    public enum GenderEnum
    {
        Male = 1,
        Female = 0
    }
}
