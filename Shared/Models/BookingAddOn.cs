namespace Shared.Models;

public class BookingAddOn
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    
    public BookingAddOn()
    {
    }
    
    public BookingAddOn(int bookingId, string name, int price, int quantity)
    {
        BookingId = bookingId;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    
}