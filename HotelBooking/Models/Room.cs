using Microsoft.AspNetCore.Mvc.ViewEngines;
using static System.Net.Mime.MediaTypeNames;

namespace HotelBooking.Models
{
    public class Room
    {
        public Guid ID { get; set; }
        public int Number { get; set; }

        public Guid HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public Guid RoomTypeID { get; set; }
        public virtual RoomType RoomType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int MaximumGuests { get; set; }
        public virtual List<Facility> Facilities { get; set; }
        public virtual List<Image> RoomImages { get; set; }

    }
}
