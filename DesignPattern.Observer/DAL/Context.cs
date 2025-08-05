using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GLCB4AC;initial catalog=DesignPattern4;integrated security=true;Encrypt=False;");
        }

        public DbSet<WelcomeMessage> welcomeMessages { get; set; } 
        public DbSet<Discount> Discounts { get; set; } 
        public DbSet<UserProcess> UserProcesses { get; set; } 
    }
}
