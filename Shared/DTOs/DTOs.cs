using Shared.Models;

namespace Shared.DTOs;

public record CenterCreationDTO(string CenterName, int ZipCode, string City, string Address, List<CourtCreationDTO>? InitialCourts);
public record CenterAdminDTO(int CenterId, string Username);
public record CourtCreationDTO(string CourtType, int CourtNumber, string? CourtSponsor);
public record CenterUpdatingDTO(int Id, string CenterName, int ZipCode, string City, string Address);
public record CourtUpdatingDTO(int Id, int CenterId, string CourtType, int CourtNumber, string CourtSponsor);
public record TimeSlotCreationDTO(int CourtId, DateTime StartTime, int Duration, bool IsBooked, int Price);
public record BookingCreationDTO(string Username, int TotalPrice, List<BookingAddOnCreationDTO>? BookingAddOns, List<TimeSlot> TimeSlots);
public record BookingAddOnCreationDTO(int BookingId, string Name, int Price, int Quantity);
public record UserCreationDTO(string Username, string Password, string Email, string Name, string Role);
public record UserLoginDTO(string Username, string Password);

