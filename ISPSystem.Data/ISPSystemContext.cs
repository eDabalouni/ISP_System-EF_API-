using ISP_System.Models;
using Microsoft.EntityFrameworkCore;

namespace ISPSystem.Data
{
    public class ISPSystemContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } //DB Table
        public DbSet<ServicePlan> ServicePlans { get; set; }
        public DbSet<Subscribing> Subscribings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= ISPSystem; Trusted_Connection=True")
                .LogTo(Console.WriteLine,
                new[] { DbLoggerCategory.Database.Command.Name },
                Microsoft.Extensions.Logging.LogLevel.Debug
                );
        }
    }
}
