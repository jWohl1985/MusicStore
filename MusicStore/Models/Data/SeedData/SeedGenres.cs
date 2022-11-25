using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.SeedData
{
    internal class SeedGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { Id = "rock", Name = "Rock" },
                new Genre { Id = "elec", Name = "Electronic" },
                new Genre { Id = "rap", Name = "Hip Hop" },
                new Genre { Id = "class", Name = "Classical" },
                new Genre { Id = "metal", Name = "Metal" },
                new Genre { Id = "indie", Name = "Independent" },
                new Genre { Id = "exp", Name = "Experimental" }
                );
        }
    }
}
