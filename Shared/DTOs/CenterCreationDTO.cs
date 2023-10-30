namespace Shared.DTOs;

public class CenterCreationDTO
{
    public string Name { get; }
    public string Location { get; }

    public CenterCreationDTO(string name, string location)
    {
        Name = name;
        Location = location;
    }
}