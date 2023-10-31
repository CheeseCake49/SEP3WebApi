namespace Shared.Models;

public class Center
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    public Center(int id, string name, string location)
    {
        Id = id;
        Name = name;
        Location = location;
    }
    
}