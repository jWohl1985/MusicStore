using Microsoft.EntityFrameworkCore;
using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Data.SeedData;

namespace MusicStore.Models.Data
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; } = default!;
        public DbSet<Album> Albums { get; set; } = default!;
        public DbSet<Track> Tracks { get; set; } = default!;
        public DbSet<AlbumType> AlbumType { get; set; } = default!;
        public DbSet<Genre> Genres { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedGenres());
            modelBuilder.ApplyConfiguration(new SeedAlbumTypes());
            modelBuilder.ApplyConfiguration(new SeedArtists());
            modelBuilder.ApplyConfiguration(new SeedAlbums());
            modelBuilder.ApplyConfiguration(new SeedTracks());
        }
    }
}
