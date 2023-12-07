namespace Shared.Models;

public class TimeSlot
{
    public int Id { get; set; }
    public int courtId { get; set; }
    public DateTime startTime { get; set; }
    public int duration { get; set; }
    
    public TimeSlot()
    {
    }
    
    public TimeSlot(int courtId, DateTime startTime, int duration)
    {
        this.courtId = courtId;
        this.startTime = startTime;
        this.duration = duration;
    }
}