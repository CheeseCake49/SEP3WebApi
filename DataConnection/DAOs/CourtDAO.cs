using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.court;
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
        CourtGrpc courtGrpc = await _courtService.UpdateCourtAsync(new CourtGrpc()
        {
            Id = dto.centerId,
            CourtType = dto.courtType,
            CourtNumber = dto.courtNumber,
            CourtSponsor = dto.courtSponsor
        });
        
        Court court = ConvertToCourt(courtGrpc);
        return court;
    }

    public async Task<Court?> GetByCenterIdAndCourtNumberAsync(int centerId, int courtNumber)
    {
        Court? existing = ConvertToCourt(await _courtService.GetByCenterIdAndCourtNumberAsync(new CourtDeletion()
        {
            CenterId = centerId,
            CourtNumber = courtNumber
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