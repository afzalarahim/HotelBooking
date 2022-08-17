namespace HotelBooking.Models
{
    public class Booking
    {
        public Guid ID { get; set; }
        public Guid HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }
        public Guid RoomID { get; set; }
       
        public DateTime DateCreated { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Guests { get; set; }
        public decimal TotalFee { get; set; }
        public bool Paid { get; set; }
        public bool Completed { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string OtherRequests { get; set; }
    }
}
