using Shared.Models;

namespace DataConnection.JavaConnection;

public class GrpcAdapter
{
    public List<Center> Centers { get; set; }

    // TODO
    public GrpcAdapter()
    {
        Centers = new List<Center>();
    }

    public void SaveChanges()
    {
        Console.WriteLine(Centers.ToString());
        // Do nothing // TODO
    }
}