using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.SeedData
{
    internal class SeedTracks : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> entity)
        {
            entity.HasData(
                new Track
                {
                    Id = 1,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Taxman",
                    TrackNumber = 1,
                    DurationInSeconds = 159,
                },
                new Track
                {
                    Id = 2,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Eleanor Rigby",
                    TrackNumber = 2,
                    DurationInSeconds = 129,
                },
                new Track
                {
                    Id = 3,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "I'm Only Sleeping",
                    TrackNumber = 3,
                    DurationInSeconds = 182,
                },
                new Track
                {
                    Id = 4,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Love You To",
                    TrackNumber = 4,
                    DurationInSeconds = 187,
                },
                new Track
                {
                    Id = 5,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Here, There And Everywhere",
                    TrackNumber = 5,
                    DurationInSeconds = 146,
                },
                new Track
                {
                    Id = 6,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Yellow Submarine",
                    TrackNumber = 6,
                    DurationInSeconds = 160,
                },
                new Track
                {
                    Id = 7,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "She Said She Said",
                    TrackNumber = 7,
                    DurationInSeconds = 159,
                },
                new Track
                {
                    Id = 8,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Good Day Sunshine",
                    TrackNumber = 8,
                    DurationInSeconds = 130,
                },
                new Track
                {
                    Id = 9,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "And Your Bird Can Sing",
                    TrackNumber = 9,
                    DurationInSeconds = 123,
                },
                new Track
                {
                    Id = 10,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "For No One",
                    TrackNumber = 10,
                    DurationInSeconds = 122,
                },
                new Track
                {
                    Id = 11,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Doctor Robert",
                    TrackNumber = 11,
                    DurationInSeconds = 137,
                },
                new Track
                {
                    Id = 12,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "I Want To Tell You",
                    TrackNumber = 12,
                    DurationInSeconds = 152,
                },
                new Track
                {
                    Id = 13,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Got to Get You Into My Life",
                    TrackNumber = 13,
                    DurationInSeconds = 157,
                },
                new Track
                {
                    Id = 14,
                    AlbumId = 1,
                    ArtistId = 1,
                    Title = "Tomorrow Never Knows",
                    TrackNumber = 14,
                    DurationInSeconds = 177,
                });
        }
    }
}
