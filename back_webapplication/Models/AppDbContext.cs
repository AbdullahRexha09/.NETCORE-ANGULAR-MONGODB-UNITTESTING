using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }
        public  DbSet<User> User { get; set; }
        public  DbSet<City> City { get; set; }
        public  DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City[]
            {
                new City{ Id = Guid.NewGuid(),Name = "Berlin", Longitude = "52.5200", Latitude = "13.4050"},
                new City{ Id = Guid.NewGuid(),Name = "Amsterdam",Longitude = "52.3676", Latitude = "4.9041"},
                new City{ Id = Guid.NewGuid(),Name = "Ljubljana", Longitude = "46.0569", Latitude = "14.5058"},
                new City{ Id = Guid.NewGuid(),Name = "Belgrade", Longitude = "44.7866", Latitude = "20.4489"},
                new City{ Id = Guid.NewGuid(),Name = "Zagreb", Longitude = "45.8150", Latitude = "15.9819"},
                new City{ Id = Guid.NewGuid(),Name = "Sarajevo", Longitude = "43.8563", Latitude = "18.4131"},
                new City{ Id = Guid.Parse("58CA7A2D-EF9D-47DA-9BA2-2A27B76DA85C"),Name = "Prishtina", Longitude = "42.6629", Latitude = "21.1655"},
                new City{ Id = Guid.NewGuid(),Name = "Rome", Longitude = "41.9028", Latitude = "12.4964"},
                new City{ Id = Guid.NewGuid(),Name = "Paris", Longitude = "48.8566", Latitude = "2.3522"},
                new City{ Id = Guid.NewGuid(),Name = "Madrid", Longitude = "40.4168", Latitude = "3.7038"},
                new City{ Id = Guid.NewGuid(),Name = "Istanbul", Longitude = "41.0082", Latitude = "28.9784"},
                new City{ Id = Guid.NewGuid(),Name = "Moscow", Longitude = "55.7558", Latitude = "37.6173"},
                new City{ Id = Guid.NewGuid(),Name = "Stockholm", Longitude = "59.3293", Latitude = "18.0686"},
            });
            modelBuilder.Entity<Location>().HasData(new Location[] {
            new Location{ Id = Guid.NewGuid(),Name = "Filan Fisteku",Address = "Kosove",CityId = Guid.Parse("58CA7A2D-EF9D-47DA-9BA2-2A27B76DA85C") },
            });
             modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        }
    }
}

