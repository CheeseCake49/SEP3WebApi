﻿using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class CenterLogic : ICenterLogic
{
    private readonly ICenterDAO centerDAO;
    private readonly ICourtLogic CourtLogic;

    public CenterLogic(ICenterDAO centerDao, ICourtLogic courtLogic)
    {
        this.centerDAO = centerDao;
        this.CourtLogic = courtLogic;
    }
    
    public async Task<Center> CreateAsync(CenterCreationDTO centerToCreate)
    {
        Center toCreate = new Center(centerToCreate.CenterName, centerToCreate.ZipCode, centerToCreate.City, centerToCreate.Address);
        
        Center created = await centerDAO.CreateAsync(toCreate);
        
        if (centerToCreate.InitialCourts != null)
        {
            List<Court> courts = new List<Court>();
            foreach (CourtCreationDTO courtToCreate in centerToCreate.InitialCourts)
            {
                courts.Add(await CourtLogic.CreateAsync(created.Id, courtToCreate));
            }
        }

        return created;
    }

    public async Task<IEnumerable<Center>> GetAllCentersAsync()
    {
        IEnumerable<Court> courts = new List<Court>();
        IEnumerable<Center> centers = await centerDAO.GetAllCentersAsync();

        foreach (Center center in centers)
        {
            courts = await CourtLogic.GetCourtsByCenterID(center.Id);
            center.Courts = courts.ToList();
        }

        return centers;
    }
}