namespace Shared.Models;

public class TimeSlot
{
    public int Id { get; set; }
    public int CourtId { get; set; }
    public DateTime StartTime { get; set; }
    public int Duration { get; set; }
    public bool IsBooked { get; set; }
    public int Price { get; set; }
    
    public TimeSlot()
    {
    }
    
    public TimeSlot(int courtId, DateTime startTime, int duration, bool isBooked, int price)
    {
        CourtId = courtId;
        StartTime = startTime;
        Duration = duration;
        IsBooked = isBooked;
        Price = price;
    }
}