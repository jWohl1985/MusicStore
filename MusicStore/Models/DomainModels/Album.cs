using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Models.Data.DomainModels
{
    public class Album
    {
        public int Id { get; set; }

        public int AlbumTypeId { get; set; }

        public string GenreId { get; set; } = default!;

        [Required]
        public string? Title { get; set; }

        [Range(1900, 2200)]
        public int Year { get; set; }

        public decimal Price { get; set; }

        [NotMapped]
        public int DurationInSeconds => Tracks.Sum(t => t.DurationInSeconds);

        [NotMapped]
        public IFormFile FormImage { get; set; } = default!;
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }


        // Navigation properties
        public virtual AlbumType AlbumType { get; set; } = default!;
        public virtual Genre Genre { get; set; } = default!;
        public virtual ICollection<Artist> Artists { get; set; } = new HashSet<Artist>();
        public virtual ICollection<Track> Tracks { get; set; } = new HashSet<Track>();

    }
}
