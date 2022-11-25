using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Data.Extensions;
using MusicStore.Models.DTOs;

namespace MusicStore.Models.Grid
{
    public class AlbumGridBuilder : GridBuilder
    {
        // constructor gets the route data from session state
        public AlbumGridBuilder(ISession sess) : base(sess)
        {

        }

        // constructor stores filtering route segments as well as paging and sorting segments stored by the base constructor
        public AlbumGridBuilder(ISession sess, AlbumGridDTO values, string defaultSortField) : base(sess, values, defaultSortField)
        {
            bool isInitial = values.Genre.IndexOf(FilterPrefix.Genre) == -1;
            
            if (isInitial)
            {
                routes.ArtistFilter = FilterPrefix.Artist + values.Artist;
                routes.GenreFilter = FilterPrefix.Genre + values.Genre;
                routes.PriceFilter = FilterPrefix.Price + values.Price;
            }
            else
            {
                routes.ArtistFilter = values.Artist;
                routes.GenreFilter = values.Genre;
                routes.PriceFilter = values.Price;
            }
        }

        public void LoadFilterSegments(string[] filter, Artist artist)
        {
            if (artist is null)
            {
                routes.ArtistFilter = FilterPrefix.Artist + filter[0];
            }
            else
            {
                routes.ArtistFilter = FilterPrefix.Artist + filter[0] + "-" + artist.Name.Slug();
            }

            routes.GenreFilter = FilterPrefix.Genre + filter[1];
            routes.PriceFilter = FilterPrefix.Price + filter[2];
        }

        public void ClearFilterSegments() => routes.ClearFilters();

        public bool IsFilterByArtist => routes.ArtistFilter != AlbumGridDTO.DefaultFilter;
        public bool IsFilterByGenre => routes.GenreFilter != AlbumGridDTO.DefaultFilter;
        public bool IsFilterByPrice => routes.PriceFilter != AlbumGridDTO.DefaultFilter;

        public bool IsSortByGenre => routes.SortField.EqualsNoCase(nameof(Genre));
        public bool IsSortByPrice => routes.SortField.EqualsNoCase(nameof(Album.Price));
    }
}
