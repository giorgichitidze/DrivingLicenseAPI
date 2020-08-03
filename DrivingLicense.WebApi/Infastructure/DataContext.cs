using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DrivingLicense.WebApi.Factories;
using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Infastructure
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite(new DatabaseConfiguration().GetDataConnectionString());
    }
}
