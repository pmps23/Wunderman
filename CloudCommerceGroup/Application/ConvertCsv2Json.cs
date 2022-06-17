using Newtonsoft.Json;

namespace CloudCommerceGroup.Application;

public class ConvertCsv2Json : Converter
{
    public override string Convert()
    {
        return JsonConvert.SerializeObject(List);
    }

    public ConvertCsv2Json(List<Person> list) : base(list)
    {
        FileExtension = "json";
    }
}