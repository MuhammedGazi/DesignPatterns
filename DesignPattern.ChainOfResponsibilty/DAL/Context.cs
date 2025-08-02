using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GLCB4AC;initial catalog=DesignPattern1;integrated security=true;Encrypt=False;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
