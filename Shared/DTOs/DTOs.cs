﻿namespace Shared.DTOs;

public record CenterCreationDTO(string CenterName, int ZipCode, string City, string Address, List<CourtCreationDTO>? InitialCourts);

public record CenterUpdatingDTO(int id, string CenterName, int ZipCode, string City, string Address);
public record CourtCreationDTO(string CourtType, int CourtNumber, string CourtSponsor);
public record CourtUpdatingDTO(int centerId, string courtType, int courtNumber, string courtSponsor);
public record UserCreationDTO(string Username, string Password, string Email, string Name, string Role);
public record UserLoginDTO(string Username, string Password);

