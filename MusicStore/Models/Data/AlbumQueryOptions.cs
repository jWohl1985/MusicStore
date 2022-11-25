using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Data.Extensions;
using MusicStore.Models.Grid;

namespace MusicStore.Models.Data
{
    public class AlbumQueryOptions : QueryOptions<Album>
    {
        public void SortFilter(AlbumGridBuilder builder)
        {
            if (builder.IsFilterByGenre)
                Where = album => album.GenreId == builder.CurrentRoute.GenreFilter;

            if (builder.IsFilterByPrice)
            {
                if (builder.CurrentRoute.PriceFilter == "under10")
                    Where = album => album.Price < 10;
                else if (builder.CurrentRoute.PriceFilter == "10to15")
                    Where = album => album.Price >= 10 && album.Price <= 15;
                else
                    Where = album => album.Price > 15;
            }

            if (builder.IsFilterByArtist)
            {
                int id = builder.CurrentRoute.ArtistFilter.ToInt();
                if (id > 0)
                    Where = album => album.Artists.Any(artist => artist.Id == id);
            }

            if (builder.IsSortByGenre)
                OrderBy = album => album.Genre.Name;
            else if (builder.IsSortByPrice)
                OrderBy = album => album.Price;
            else
                OrderBy = album => album.Year;
        }
    }
}
