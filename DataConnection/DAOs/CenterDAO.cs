using Application.DAOInterfaces;
using Google.Protobuf.WellKnownTypes;
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
            ZipCode = center.ZipCode,
            City = center.City,
            Address = center.Address,
        });
        
        return ConvertToCenter(createdCenter);
    }

    public async Task<List<Center>> GetAllCentersAsync()
    {
        var centers = await _centerService.GetCentersAsync(new Empty());
        List<Center> centerList = new();
        for (int i = 0; i < centers.Center.Count; i++)
        {
            centerList.Add(ConvertToCenter(centers.Center[i]));
        }
        return centerList;
    }
    

    public Task<Center?> GetByNameAsync(string name)
      {
          return null;
          // Center? existing = _centerService.FirstOrDefault(c =>
          //     c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
          // );
          // return Task.FromResult(existing);
      }
      
    private Center ConvertToCenter(CenterGrpc center)
    {
        return new Center
        {
            Id = center.Id,
            Name = center.Name,
            ZipCode = center.ZipCode,
            City = center.City,
            Address = center.Address
        };
    }
}