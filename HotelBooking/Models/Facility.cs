namespace HotelBooking.Models
{
    public class Facility
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public FacilityType Type { get; set; }
    }

    public enum FacilityType
    {
        Hotel,
        Room
    }
}
