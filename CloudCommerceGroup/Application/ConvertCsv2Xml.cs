using System.Xml.Serialization;

namespace CloudCommerceGroup.Application;

public class ConvertCsv2Xml : Converter
{
    public override string Convert()
    {
        XmlSerializer serializer = new(typeof(List<Person>));

        StringWriter stringWriter = new();
        serializer.Serialize(stringWriter, List);
            
        return stringWriter.ToString();
    }

    public ConvertCsv2Xml(List<Person> list) : base(list)
    {
        FileExtension = "xml";
    }

}