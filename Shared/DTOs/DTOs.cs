﻿namespace Shared.DTOs;

public record CenterCreationDTO(string CenterName, int ZipCode, string City, string Address, List<CourtCreationDTO>? InitialCourts);
public record CourtCreationDTO(string CourtType, int CourtNumber, string CourtSponsor);
public record CourtDeletionDTO(int CenterId, int CourtNumber);