using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models.Data.DomainModels
{
    public class Artist
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public bool IsActive { get; set; } = false;

        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();
    }
}
