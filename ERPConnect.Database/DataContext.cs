using ERPConnect.Database.Models.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ERPConnect.Database
{
    
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base (options){}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder.UseSqlite("Data Source=ERPConnect.db");
           }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
           base.OnModelCreating(modelBuilder);
        }
    }

      public class BloggingContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlite("Data Source=ERPConnect.db");

            return new DataContext(optionsBuilder.Options);
        }
    }
}