using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFastFoodProject.Models;

namespace MyFastFoodProject.DAL
{
    public class AppDbContext : IdentityDbContext<ProgramUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasData(
                new Slider {Id=1, Tittle = "Burger", Subtitle = "withmushroom", Description = "tasty", LastPrice = "$17", NewPrice = "$12", ImgUrl = "3af2761a-1bc2-4674-939e-abf963f4e06cblog-details", IsCheck = true }
                );
        }
    }
}
