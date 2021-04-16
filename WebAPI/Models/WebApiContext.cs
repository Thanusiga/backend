using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class WebApiContext : DbContext
    {

        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(table => new {
                table.userId,
                table.userName,
                table.email
            });
        }

        

        public DbSet<User> Users{ get; set; }
    }
}
