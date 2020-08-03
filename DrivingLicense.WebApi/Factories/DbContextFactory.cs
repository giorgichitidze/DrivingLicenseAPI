using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DrivingLicense.WebApi.Infastructure;

namespace DrivingLicense.WebApi.Factories
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        private static string DataConnectionString => new DatabaseConfiguration().GetDataConnectionString();

        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            optionsBuilder.UseSqlite(DataConnectionString);

            return new DataContext(optionsBuilder.Options);
        }
    }
}
