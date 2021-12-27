using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimurghEngine.API.Entities;
using SimurghEngine.API.Entities.CMS;

namespace SimurghEngine.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
    }
}