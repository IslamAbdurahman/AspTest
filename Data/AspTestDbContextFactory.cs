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
            // appsettings.json dan o‘qish
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Loyihaning ildizi
                .AddJsonFile("appsettings.json")              // Connection string shu yerda
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AspTestDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new AspTestDbContext(optionsBuilder.Options);
        }
    }
}
