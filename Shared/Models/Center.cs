namespace Shared.Models;

public class Center
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ZipCode { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public List<Court> Courts { get; set; }

    
    
    public Center(string name, int zipCode, string city, string address)
    {
        Name = name;
        ZipCode = zipCode;
        City = city;
        Address = address;
        Courts = new List<Court>();
    }

    public Center()
    {
    }

    public void AddCourt(Court court)
    {
        Courts.Add(court);
    }
    
}