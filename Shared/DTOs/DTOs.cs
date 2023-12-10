namespace Shared.DTOs;

public record CenterCreationDTO(string CenterName, int ZipCode, string City, string Address, List<CourtCreationDTO>? InitialCourts);
public record CourtCreationDTO(string CourtType, int CourtNumber, string CourtSponsor);
public record TimeSlotCreationDTO(int courtId, DateTime startTime, int duration, bool isBooked);
public record BookingCreationDTO(string Username, int TotalPrice, List<BookingAddOnCreationDTO>? BookingAddOns);
public record BookingAddOnCreationDTO(int BookingId, string Name, int Price, int Quantity);
public record CourtDeletionDTO(int CenterId, int CourtNumber);
public record UserCreationDTO(string Username, string Password, string Email, string Name, string Role);
public record UserLoginDTO(string Username, string Password);

