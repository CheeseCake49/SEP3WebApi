using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class CenterLogic : ICenterLogic
{
    private readonly ICenterDAO _centerDao;
    private readonly ICourtLogic _courtLogic;

    public CenterLogic(ICenterDAO centerDao, ICourtLogic courtLogic)
    {
        _centerDao = centerDao;
        _courtLogic = courtLogic;
    }
    
    public async Task<Center> CreateAsync(CenterCreationDTO centerToCreate)
    {
        Center toCreate = new Center(centerToCreate.CenterName, centerToCreate.ZipCode, centerToCreate.City, centerToCreate.Address);
        
        Center created = await _centerDao.CreateAsync(toCreate);
        
        if (centerToCreate.InitialCourts != null)
        {
            List<Court> courts = new List<Court>();
            foreach (CourtCreationDTO courtToCreate in centerToCreate.InitialCourts)
            {
                courts.Add(await _courtLogic.CreateAsync(created.Id, courtToCreate));
            }

            created.Courts = courts;
        }
        
        return created;
    }

    public async Task DeleteAsync(int id)
    {
        await _centerDao.DeleteAsync(id);
    }

    public async Task UpdateAsync(CenterUpdatingDTO dto)
    {
        Center? existing = await _centerDao.GetByIdAsync(dto.id);
        if (existing == null)
        {
            throw new Exception($"Center with ID {dto.id} doesn't exist!");
        }

        await _centerDao.UpdateAsync(dto);
    }

    public async Task<IEnumerable<Center>> GetAllCentersAsync()
    {
        List<Court> courts;
        List<Center> centers = await _centerDao.GetAllCentersAsync();

        foreach (Center center in centers)
        {
            courts = await _courtLogic.GetCourtsByCenterID(center.Id);
            center.Courts = courts.ToList();
        }

        return centers;
    }

    public async Task<Center?> GetByIdAsync(int id)
    {
        Center? existing = await _centerDao.GetByIdAsync(id);
        if (existing == null)
        {
            throw new Exception($"Center with ID {id} doesn't exist!");
        }

        return existing;
    }
}