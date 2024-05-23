using Microsoft.EntityFrameworkCore;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.DataAccess
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<CareCenter> CareCenter { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Resident> Resident { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Entities.Task> Task { get; set; }
    }
}
