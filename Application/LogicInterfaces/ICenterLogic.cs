﻿using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICenterLogic
{
    Task<Center> CreateAsync(CenterCreationDTO centerToCreate);
    Task<IEnumerable<Center>> GetAllCentersAsync();
}