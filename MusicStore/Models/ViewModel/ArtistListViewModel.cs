using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Grid;

namespace MusicStore.Models.ViewModel
{
    public class ArtistListViewModel
    {
        public IEnumerable<Artist> Artists { get; set; } = default!;
        public RouteDictionary CurrentRoute { get; set; } = default!;
        public int TotalPages { get; set; }
    }
}
