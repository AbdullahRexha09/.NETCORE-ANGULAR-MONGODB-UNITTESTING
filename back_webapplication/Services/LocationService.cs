using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public class LocationService : ILocationService
    {
        public readonly AppDbContext _db;
        public LocationService(AppDbContext _db) 
        {
            this._db = _db;
        }
        public bool AddLocation(Location location)
        {
            var item = _db.Location.Add(location);
            if (item.State == EntityState.Added) 
            {
                _db.SaveChanges();
                return true;
            }
            
            return false;
        }

        public bool DeleteLocation(Guid Id)
        {
            Location location = _db.Location.FirstOrDefault(x => x.Id == Id);
            var item = _db.Location.Remove(location);
            if (item.State == EntityState.Deleted) 
            {
                _db.SaveChanges();
                return true;
            }
            return false;
            
        }

        public List<Location> GetAllLocations()
        {
            return _db.Location.ToList();
        }
        public List<City> GetAllCities() 
        {
            return _db.City.ToList();
        }
        public Location GetLocationById(Guid id) 
        {
            return _db.Location.First(x => x.Id == id);
        }
        public bool UpdateLocation(Location location) 
        {
            var item = _db.Location.Update(location);
            if (item.State == EntityState.Modified)
            {
                _db.SaveChanges();
                return true;
            }
            return false;
            
        }
    }
}
