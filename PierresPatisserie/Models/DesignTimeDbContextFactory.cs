using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierresPatisserie.Models
{
  public class PierresPatisserieContextFactory : IDesignTimeDbContextFactory<PierresPatisserieContext>
  {

    PierresPatisserieContext IDesignTimeDbContextFactory<PierresPatisserieContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierresPatisserieContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PierresPatisserieContext(builder.Options);
    }
  }
}