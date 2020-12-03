using System.ComponentModel;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DrivingLicense.WebApi.Factories;
using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Infastructure
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {


        public DbSet<Answer> Answer {get;set;}
        public DbSet<Ticket> Ticket {get;set;}
        public DbSet<Topic> Topic {get;set;}
        public DbSet<LicenseCategory> LicenseCategory {get;set;}


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LicenseCategory>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Answer>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Ticket>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Topic>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
        }

        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite(new DatabaseConfiguration().GetDataConnectionString());
    }
}
