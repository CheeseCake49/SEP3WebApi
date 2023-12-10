namespace Shared.Models;

public class TimeSlot
{
    public int Id { get; set; }
    public int courtId { get; set; }
    public DateTime startTime { get; set; }
    public int duration { get; set; }
    public bool isBooked { get; set; }
    
    public TimeSlot()
    {
    }
    
    public TimeSlot(int courtId, DateTime startTime, int duration, bool isBooked)
    {
        this.courtId = courtId;
        this.startTime = startTime;
        this.duration = duration;
        this.isBooked = isBooked;
    }
}