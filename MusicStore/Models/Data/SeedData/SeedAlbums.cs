using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.SeedData
{
    internal class SeedAlbums : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> entity)
        {
            entity.HasData(
                new Album
                {
                    Id = 1,
                    Title = "Revolver",
                    Year = 1966,
                    AlbumTypeId = 1,
                    GenreId = "rock",
                    Price = 8.99M,
                }
                );
        }
    }
}
