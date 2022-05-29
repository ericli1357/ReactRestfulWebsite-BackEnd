using Microsoft.EntityFrameworkCore;

namespace ReactRestfulWebsite.Data
{
    public class ReactRestfulWebsiteContext : DbContext
    {
        public ReactRestfulWebsiteContext(DbContextOptions<ReactRestfulWebsiteContext> options) : base(options){ }

        public DbSet<Category> Category { get; set; }
        public DbSet<Article> Article { get; set; }
    }
}
