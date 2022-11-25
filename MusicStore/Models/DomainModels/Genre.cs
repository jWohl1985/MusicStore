using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models.Data.DomainModels
{
    public class Genre
    {
        public string Id { get; set; } = default!;

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; } = new HashSet<Album>();
        public virtual ICollection<Artist> Artists { get; set; } = new HashSet<Artist>();
    }
}
