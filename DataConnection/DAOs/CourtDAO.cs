using Application.DAOInterfaces;
using Grpc.Core;
using Grpc.Net.Client;
using sep3client.proto;
using Shared.DTOs;
using Shared.Models;

namespace DataConnection.DAOs;

public class CourtDAO : ICourtDAO
{

    private readonly CourtService.CourtServiceClient _courtService;

    public CourtDAO()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _courtService = new CourtService.CourtServiceClient(channel);
    }

    public async Task<Court> CreateAsync(Court court)
    {
        CourtGrpc createdCourt = await _courtService.CreateCourtAsync(new CreatingCourt()
        {
            CenterId = court.CenterId,
            CourtType = court.CourtType,
            CourtNumber = court.CourtNumber,
            CourtSponsor = court.CourtSponsor
        });

        return ConvertToCourt(createdCourt);
    }

    public async Task DeleteAsync(int centerId, int courtNumber)
    {
        await _courtService.DeleteCourtFromCenterIdAsync(new CourtDeletion()
        {
            CenterId = centerId,
            CourtNumber = courtNumber
        });
    }

    public async Task<List<Court>> GetCourtsByCenterID(int centerID)
    {
        var courts = await _courtService.GetCourtsFromCenterIdAsync(new CenterId()
        {
            Id = centerID
        });
        List<Court> courtList = new();
        for (int i = 0; i < courts.Court.Count; i++)
        {
            courtList.Add(ConvertToCourt(courts.Court[i]));
        }
        return courtList;
    }

    public async Task<Court> UpdateAsync(CourtUpdatingDTO dto)
    {
        CourtGrpc courtGrpc = await _courtService.UpdateCourtAsync(new UpdatingCourt()
        {
            Id = dto.Id,
            CourtType = dto.CourtType,
            CourtNumber = dto.CourtNumber,
            CourtSponsor = dto.CourtSponsor
        });
        
        return ConvertToCourt(courtGrpc);
    }

    public async Task<Court?> GetByCenterIdAndCourtNumberAsync(int centerId, int courtNumber)
    {
        CourtGrpc existing;
        try
        { 
            existing = await _courtService.GetByCenterIdAndCourtNumberAsync(new CourtDeletion() 
            { 
                CenterId = centerId, 
                CourtNumber = courtNumber 
            });
        }
        catch (RpcException e)
        {
            existing = null;
        }
        
        return existing == null ? null : ConvertToCourt(existing);
    }

    public async Task<Court?> GetByIdAsync(int id)
    {
        Court? existing = ConvertToCourt(await _courtService.GetByIdAsync(new CourtId()
        {
            Id = id
        }));
        return existing;
    }

    private Court ConvertToCourt(CourtGrpc court)
    {
        return new Court()
        {
            Id = court.Id,
            CenterId = court.CenterId,
            CourtType = court.CourtType,
            CourtNumber = court.CourtNumber,
            CourtSponsor = court.CourtSponsor
        };
    }
}