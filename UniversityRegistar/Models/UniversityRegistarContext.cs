using Microsoft.EntityFrameworkCore;

namespace UniversityRegistar.Models
{
  public class UniversityRegistarContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Registry> Registry { get; set; }
    public DbSet<Department> Departments {get; set;}
    public DbSet<Course_Department> Course_Department{get; set;}

    public UniversityRegistarContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}