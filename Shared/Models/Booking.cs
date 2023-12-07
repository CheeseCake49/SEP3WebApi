namespace Shared.Models;

public class Booking
{
    public int Id { get; set; }
    public string Username { get; set; }
    public int TotalPrice { get; set; }
    public List<BookingAddOn> BookingAddOns { get; set; }
    
    public Booking()
    {
    }
    
public Booking(string username, int totalPrice)
    {
        Username = username;
        TotalPrice = totalPrice;
        BookingAddOns = new List<BookingAddOn>();
    }
}