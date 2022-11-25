using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.SeedData
{
    internal class SeedAlbumTypes : IEntityTypeConfiguration<AlbumType>
    {
        public void Configure(EntityTypeBuilder<AlbumType> entity)
        {
            entity.HasData(
                new AlbumType { Id = 1, Name = "LP" },
                new AlbumType { Id = 2, Name = "EP" },
                new AlbumType { Id = 3, Name = "Single" },
                new AlbumType { Id = 4, Name = "Split" },
                new AlbumType { Id = 5, Name = "Compilation" }
                );
        }
    }
}
