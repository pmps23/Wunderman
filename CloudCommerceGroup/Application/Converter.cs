namespace CloudCommerceGroup.Application;

public abstract class Converter
{
    protected readonly List<Person> List;

    protected string FileExtension;
    public abstract string Convert();

    protected Converter(List<Person> list)
    {
        List = list;
        FileExtension = "txt";
    }

    public void Write2File(string fileContent)
    {
        try
        {
            string fileName = $"Converted.{FileExtension}";
            File.WriteAllText(fileName, fileContent);
            Console.WriteLine($"The converted file is {fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}