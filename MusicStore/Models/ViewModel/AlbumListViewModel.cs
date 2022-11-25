using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Grid;

namespace MusicStore.Models.ViewModel
{
    public class AlbumListViewModel
    {
        public IEnumerable<Album> Albums { get; set; } = default!;
        public RouteDictionary CurrentRoute { get; set; } = default!;
        public int TotalPages { get; set; }

        public IEnumerable<Artist> Artists { get; set; } = default!;
        public IEnumerable<Genre> Genres { get; set; } = default!;
        public IEnumerable<AlbumType> AlbumType { get; set; } = default!;

        public Dictionary<string, string> Prices => new Dictionary<string, string>
        {
            { "under10", "Under $10" },
            { "10to15", "$10 to $15" },
            { "over15", "Over $15" },
        };
    }
}
