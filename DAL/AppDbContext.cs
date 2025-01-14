using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Testgithub2.Models;

namespace Testgithub2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        { }
         public DbSet<Employee> Employees { get; set; }
        public DbSet<Profession> Professions { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(c => c.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }



    }
 
}
