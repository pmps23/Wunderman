using CloudCommerceGroup.Model;

namespace CloudCommerceGroup;

public class Person
{
    public string name;
    public Address address;

    public static Person FromCsv(string csvLine)
    {
        var values = csvLine.Split(',');
        
        var person = new Person
        {
            name = values[0],
            address = new Address
            {
                line1 = values[1],
                line2 = values[2]
            }
        };

        return person;
    }
}