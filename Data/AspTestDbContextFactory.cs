using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AspTest.Data
{
    public class AspTestDbContextFactory : IDesignTimeDbContextFactory<AspTestDbContext>
    {
        public AspTestDbContext CreateDbContext(string[] args)
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json")              
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AspTestDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new AspTestDbContext(optionsBuilder.Options);
        }
    }
}
