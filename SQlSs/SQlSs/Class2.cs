using Microsoft.EntityFrameworkCore;

namespace SQlSs
{
    public class ApplicationContext : DbContext
    {
    public DbSet<Student> Students => Set<Student>();
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=StudentsApp.db");
        }
  
    }
}