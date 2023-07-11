using IDGS902_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace IDGS902_Api.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options) { }
        public DbSet<alumnos> alumnos { get; set; }
    }
}
