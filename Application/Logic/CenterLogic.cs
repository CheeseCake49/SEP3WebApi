using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class CenterLogic : ICenterLogic
{
    private readonly ICenterDAO centerDAO;

    public CenterLogic(ICenterDAO centerDao)
    {
        this.centerDAO = centerDao;
    }
    
    public async Task<Center> CreateAsync(CenterCreationDTO centerToCreate)
    {
        Center toCreate = new Center(centerToCreate.Name, centerToCreate.Location);
        
        Center created = await centerDAO.CreateAsync(toCreate);

        return created;
    }
    
}