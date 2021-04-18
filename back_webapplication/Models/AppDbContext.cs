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
        public DbSet<PMLTask> PMLTask { get; set; }
        public DbSet<PMLList> PMLList { get; set; }

     
    }
}

