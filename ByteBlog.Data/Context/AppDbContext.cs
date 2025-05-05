using ByteBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace ByteBlog.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PCL5CR6\\SQLEXPRESS;database=ByteBlogDb;integrated security=true");
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
