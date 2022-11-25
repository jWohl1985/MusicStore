using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models.Data.DomainModels
{
    public class Track
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }

        [Required]
        public string? Title { get; set; }
        public int TrackNumber { get; set; }

        public int DurationInSeconds { get; set; }
    }
}
