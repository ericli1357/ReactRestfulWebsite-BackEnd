using Microsoft.EntityFrameworkCore;

namespace ReactRestfulWebsite.Data
{
    public class ReactRestfulWebsiteContext : DbContext
    {
        public ReactRestfulWebsiteContext(DbContextOptions<ReactRestfulWebsiteContext> options) : base(options){ }

        public DbSet<Category> Category { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-06S14QK;Database=ReactRestfulWebsite;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
