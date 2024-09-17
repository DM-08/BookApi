namespace BookApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateOnly BookingDate { get; set; }
    }
}

