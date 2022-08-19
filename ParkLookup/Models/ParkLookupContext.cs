using Microsoft.EntityFrameworkCore;

namespace ParkLookup.Models
{
    public class ParkLookupContext : DbContext
    {
        public ParkLookupContext(DbContextOptions<ParkLookupContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 1, Name = "Crater Lake", Type = "National Park", Location = "Oregon", Feature = "Deepest and Clearest lake in USA." },
                new Park { ParkId = 2, Name = "Lassen Volcanic", Type = "National Park", Location = "California", Feature = "Lakes, hot springs, cincer cones, and lava beds." },
                new Park { ParkId = 3, Name = "Denali", Type = "National Park and Preserve", Location = "Alaska", Feature = "Tallest peak in North America and over 6 million acres of wilderness." },
                new Park { ParkId = 4, Name = "Smith Rock", Type = "State Park", Location = "Oregon", Feature = "Sweeping views and several thousand climbs, with over a thousand bolted routes." },
                new Park { ParkId = 5, Name = "Ponderosa", Type = "State Park", Location = "Idaho", Feature = "Camp, fish, run, climb, bike, boat, ride horses, sail, and more at this lively recreational destination." },
                new Park { ParkId = 6, Name = "Mount Rainier", Type = "National Park", Location = "Washington", Feature = "Iconic and ACTIVE volcano. Turqoise lakes and views galore." },
                new Park { ParkId = 7, Name = "Ecola", Type = "State Park", Location = "Oregon", Feature = "Stunning coastline and classic beach town." }
            );
        }
    }
}