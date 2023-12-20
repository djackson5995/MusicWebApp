using Microsoft.EntityFrameworkCore;
using MusicWebApp.Model;

namespace MusicWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)

        {

        }

    }
}
