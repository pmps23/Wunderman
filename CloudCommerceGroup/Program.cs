using CloudCommerceGroup.Application;

namespace CloudCommerceGroup;

internal class Program
{
    private static void Main(string[] args)
    {
        //Usage
        //CloudCommerceGroup.exe csv2json|csv2xml input.csv

        //example:
        //name,address_line1,address_line2 
        //Dave, Street, Town

        List<Person> list = File.ReadAllLines(args[1])
            .Skip(1)
            .Select(Person.FromCsv)
            .ToList();

        switch (args[0])
        {
            case "csv2json":
            {
                // CSV to JSON
                ConvertCsv2Json objCsv2Json = new(list);
                string json = objCsv2Json.Convert();
                Console.WriteLine(json);
                objCsv2Json.Write2File(json);
                break;
            }
            case "csv2xml":
            {
                // CSV to XML
                ConvertCsv2Xml objCsv2Xml = new(list);
                string xml = objCsv2Xml.Convert();
                Console.WriteLine(xml);
                objCsv2Xml.Write2File(xml);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid conversion!");
                Console.WriteLine("Usage: CloudCommerceGroup.exe csv2json|csv2xml input.csv");
                break;
            }
        }
    }
}