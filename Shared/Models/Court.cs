namespace Shared.Models;

public class Court
{
    public int Id { get; set; }
    public int CenterId { get; set; }
    public string CourtType { get; set; }
    public int CourtNumber { get; set; }
    public string CourtSponsor { get; set; }

    public Court(int centerId, string courtType, int courtNumber, string courtSponsor)
    {
        CenterId = centerId;
        CourtType = courtType;
        CourtNumber = courtNumber;
        CourtSponsor = courtSponsor;
    }

    public Court()
    {
        
    }
}