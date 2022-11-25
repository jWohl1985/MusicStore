using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.SeedData
{
    internal class SeedArtists : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> entity)
        {
            entity.HasData(
                new Artist
                {
                    Id = 1,
                    Name = "The Beatles",
                    IsActive = false,
                });
        }
    }
}
