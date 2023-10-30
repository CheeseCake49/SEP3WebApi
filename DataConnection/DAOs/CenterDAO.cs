using Application.DAOInterfaces;
using DataConnection.JavaConnection;
using Shared.Models;

namespace DataConnection.DAOs;

public class CenterDAO : ICenterDAO
{
    private readonly GrpcAdapter _adapter;

    public CenterDAO(GrpcAdapter adapter)
    {
        this._adapter = adapter;
    }

    public async Task<Center> CreateAsync(Center center)
    {
        int CenterId = 1;
        if (_adapter.Centers.Any())
        {
            CenterId = _adapter.Centers.Max(c => c.Id);
            CenterId++;
        }

        center.Id = CenterId;

        _adapter.Centers.Add(center);
        _adapter.SaveChanges(); //TODO

        return center;
    }

    public Task<Center?> GetByNameAsync(string name)
    {
        Center? existing = _adapter.Centers.FirstOrDefault(c =>
            c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
        );
        return Task.FromResult(existing);
    }
}