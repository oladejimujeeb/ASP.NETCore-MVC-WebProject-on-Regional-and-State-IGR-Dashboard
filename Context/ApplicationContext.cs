using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication2.Entities;

namespace WebApplication2.Context
{
    public class ApplicationContext:DbContext
    {
        public DbSet<State>States { get; set; }
        public DbSet<Region>Regions { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
    }
}