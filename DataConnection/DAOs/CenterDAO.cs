using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.center;
using Shared.Models;

namespace DataConnection.DAOs;

public class CenterDAO : ICenterDAO
{
    
    private readonly CenterService.CenterServiceClient _centerService;

    public CenterDAO()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _centerService = new CenterService.CenterServiceClient(channel);
    }

    public async Task<Center> CreateAsync(Center center)
    {
        CenterGrpc createdCenter = await _centerService.CreateCenterAsync(new CreatingCenter()
        {
            Name = center.Name,
            Location = center.Location
        });
        
        return ConvertToCenter(createdCenter);
    }
    

      public Task<Center?> GetByNameAsync(string name)
      {
          return null;
          // Center? existing = _centerService.FirstOrDefault(c =>
          //     c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
          // );
          // return Task.FromResult(existing);
      }

    public static Center ConvertToCenter(CenterGrpc center)
    {
        return new Center
        {
            Id = center.Id,
            Name = center.Name,
            Location = center.Location
        };
    }
}