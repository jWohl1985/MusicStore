using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models.Data.DomainModels
{
    public class AlbumType
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }


        // Navigation properties
        public virtual ICollection<Album> Albums { get; set; } = new HashSet<Album>();
    }
}
