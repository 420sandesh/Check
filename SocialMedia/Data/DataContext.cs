using Microsoft.EntityFrameworkCore;
using SocialMedia.Models;
using System.Collections.Generic;

namespace SocialMedia.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options) 
        {
        }
        public DbSet<AppUser> Users { get; set; }

    }
}
