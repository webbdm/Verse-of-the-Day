
using Microsoft.EntityFrameworkCore;

namespace webbdm_verse_of_the_day.Models
{
    public class AppDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite(@"Data Source=/tmp/blogging.db");
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Verse> Verses { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

    }
}
