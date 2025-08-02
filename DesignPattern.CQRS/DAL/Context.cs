using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GLCB4AC;initial catalog=DesignPattern2;integrated security=true;Encrypt=False;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
