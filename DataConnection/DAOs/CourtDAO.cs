using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.court;
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

    public async Task<IEnumerable<Court>> GetCourtsByCenterID(int centerID)
    {
        var courts = await _courtService.GetCourtsFromCenterIdAsync(new CenterId()
        {
            Id = centerID
        });
        return courts.Court.Select(ConvertToCourt);
    }

    private static Court ConvertToCourt(CourtGrpc court)
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