using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Column> columns { get; set; } = null!;
        public DbSet<Building> buildings { get; set; } = null!;
        public DbSet<Battery> batteries { get; set; } = null!;
        public DbSet<Elevator> elevators { get; set; } = null!;
        public DbSet<Intervention> interventions { get; set; } = null!;
    }
}