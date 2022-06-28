using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ShopAssignment.Data.Context
{
    public class ShopAssignmentDBContextFactory : IDesignTimeDbContextFactory<ShopAssignmentDBContext>
    {
        public ShopAssignmentDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopAssignmentDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<ShopAssignmentDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopAssignmentDBContext(optionsBuilder.Options);
        }
    }
}