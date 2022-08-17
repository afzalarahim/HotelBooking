namespace HotelBooking.Models
{
    public class Review
    {
        public Guid ID { get; set; }
        public Guid HotelId { get; set; }
        public virtual Hotel Room { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerEmail { get; set; }
        public string Description { get; set; }
    }

}
