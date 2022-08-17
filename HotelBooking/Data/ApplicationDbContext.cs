using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace HotelBooking.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Booking>().Property(p => p.TotalFee).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<RoomType>().Property(p => p.BasePrice).HasColumnType("decimal(18,2)");
        }

    }
}
