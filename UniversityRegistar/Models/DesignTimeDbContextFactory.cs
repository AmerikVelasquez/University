using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace UniversityRegistar.Models
{
  public class UniversityRegistarContextFactory : IDesignTimeDbContextFactory<UniversityRegistarContext>
  {
    UniversityRegistarContext IDesignTimeDbContextFactory<UniversityRegistarContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var builder = new DbContextOptionsBuilder<UniversityRegistarContext>();

        builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

        return new UniversityRegistarContext(builder.Options);
    }
  }
}