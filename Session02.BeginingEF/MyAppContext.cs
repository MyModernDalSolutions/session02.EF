using Microsoft.EntityFrameworkCore;

namespace Session02.BeginingEF
{
    public class MyAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //add entityframworkcore.sqlserver Nuget Package
            optionsBuilder.UseSqlServer("server=.;database=BeginingEf;integrated security=true");
            base.OnConfiguring(optionsBuilder); 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
