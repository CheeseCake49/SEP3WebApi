using Application.DAOInterfaces;
using Application.Logic;
using DataConnection.DAOs;
using Shared.DTOs;

namespace UnitTests;

[TestClass]
public class CenterTests
{

    [TestMethod]
    public void AddCenterTest()
    {
        ICenterDAO centerDao = new CenterDAO();
        ICourtDAO courtDao = new CourtDAO();
        CourtLogic courtLogic = new CourtLogic(courtDao);
        CenterLogic centerLogic = new CenterLogic(centerDao, courtLogic);

        CenterCreationDTO centerCreationDto = new CenterCreationDTO("Smash", 8700, "Horsens", "Vimmersvej 3", null);
        
        
    }
    
}