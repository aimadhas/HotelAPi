using Microsoft.EntityFrameworkCore;

namespace UdemyTestAplication.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options) { 
        
       
        }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
