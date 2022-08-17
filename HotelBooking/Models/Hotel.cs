using Microsoft.AspNetCore.Mvc.ViewEngines;
using static System.Net.Mime.MediaTypeNames;

namespace HotelBooking.Models
{
    public class Hotel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public virtual List<Room> Rooms { get; set; }
        public virtual List<Facility> Facilities { get; set; }
        public virtual List<Image> RoomImages { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
