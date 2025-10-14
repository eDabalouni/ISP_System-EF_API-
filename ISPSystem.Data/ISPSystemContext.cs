
﻿using ISPSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Adding join table
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.ServicePlans)
                .WithMany(s => s.Customers)
                .UsingEntity<Subscribing>();

            //Seeding data
            modelBuilder.Entity<ServicePlan>().HasData(
                new ServicePlan { Id = 1, Speed = 500, Size = 1, Price = 349.33, Status = ServicePlan.PlanStatus.Active },
                new ServicePlan { Id = 2, Speed = 400, Size = 4, Price = 667.33, Status = ServicePlan.PlanStatus.Inactive },
                new ServicePlan { Id = 3, Speed = 300, Size = 3, Price = 593, Status = ServicePlan.PlanStatus.Active }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "elaf",
                    Email = "elafdabalouni@gmail.com",

                });
        }

    }
}
