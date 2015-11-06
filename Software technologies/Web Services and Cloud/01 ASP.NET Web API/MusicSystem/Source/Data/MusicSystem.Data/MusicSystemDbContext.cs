namespace MusicSystem.Data
{
    using System.Data.Entity;

    using Models;

    public class MusicSystemDbContext : DbContext
    {
        public MusicSystemDbContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Song> Songs { get; set; }
    }
}
