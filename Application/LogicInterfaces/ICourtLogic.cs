﻿using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICourtLogic
{
    Task<Court> CreateAsync(int CenterId, CourtCreationDTO courtToCreate);
    Task DeleteAsync(int centerId, int courtNumber);
    Task<List<Court>> GetCourtsByCenterID(int centerID);
}