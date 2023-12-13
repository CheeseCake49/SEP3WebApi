using Application.DAOInterfaces;
using Application.Logic;
using Application.LogicInterfaces;
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
        ITimeSlotDAO timeSlotDao = new TimeSlotDAO();
        ITimeSlotLogic timeSlotLogic = new TimeSlotLogic(timeSlotDao);
        CourtLogic courtLogic = new CourtLogic(courtDao, timeSlotLogic);
        CenterLogic centerLogic = new CenterLogic(centerDao, courtLogic);

        CenterCreationDTO centerCreationDto = new CenterCreationDTO("Smash", 8700, "Horsens", "Vimmersvej 3", null);
    }

    [TestMethod]
    public void AddCenterAdmin()
    {
        ICenterDAO centerDao = new CenterDAO();

        string result = centerDao.AddCenterAdminAsync(1, "Luu").Result;
        Console.WriteLine(result);
        result = centerDao.AddCenterAdminAsync(10, "Johan").Result;
        Console.WriteLine(result);
    }

}