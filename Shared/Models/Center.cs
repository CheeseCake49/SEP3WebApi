namespace Shared.Models;

public class Center
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    
    
    public Center(string name, string location)
    {
        Name = name;
        Location = location;
    }

    public Center()
    {
    }
    
}