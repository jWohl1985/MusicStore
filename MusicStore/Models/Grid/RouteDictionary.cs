using MusicStore.Models.Data.Extensions;
using MusicStore.Models.DTOs;

namespace MusicStore.Models.Grid
{
    public class RouteDictionary : Dictionary<string, string>
    {
        public int PageNumber
        {
            get => Get(nameof(GridDTO.PageNumber)).ToInt();
            set => this[nameof(GridDTO.PageNumber)] = value.ToString();
        }

        public int PageSize
        {
            get => Get(nameof(GridDTO.PageSize)).ToInt();
            set => this[nameof(GridDTO.PageSize)] = value.ToString();
        }

        public string SortField
        {
            get => Get(nameof(GridDTO.SortField));
            set => this[nameof(GridDTO.SortField)] = value.ToString();
        }

        public string SortDirection
        {
            get => Get(nameof(GridDTO.SortDirection));
            set => this[nameof(GridDTO.SortDirection)] = value.ToString();
        }

        public string GenreFilter
        {
            get => Get(nameof(AlbumGridDTO.Genre)).Replace(FilterPrefix.Genre, "");
            set => this[nameof(AlbumGridDTO.Genre)] = value;
        }

        public string PriceFilter
        {
            get => Get(nameof(AlbumGridDTO.Price)).Replace(FilterPrefix.Price, "");
            set => this[nameof(AlbumGridDTO.Price)] = value;
        }

        public string ArtistFilter
        {
            get
            {
                string s = Get(nameof(AlbumGridDTO.Artist)).Replace(FilterPrefix.Artist, "");
                int index = s.IndexOf('-');
                return (index == -1) ? s : s.Substring(0, index);
            }
            set => this[nameof(AlbumGridDTO.Artist)] = value;
        }

        private string Get(string key) => Keys.Contains(key) ? this[key] : null;

        public void SetSortAndDirection(string fieldName, RouteDictionary current)
        {
            this[nameof(GridDTO.SortField)] = fieldName;

            if (current.SortField.EqualsNoCase(fieldName) && current.SortDirection == "asc")
                this[nameof(GridDTO.SortDirection)] = "desc";
            else
                this[nameof(GridDTO.SortDirection)] = "asc";
        }

        public void ClearFilters() => GenreFilter = PriceFilter = ArtistFilter = AlbumGridDTO.DefaultFilter;

        public RouteDictionary Clone()
        {
            var clone = new RouteDictionary();
            foreach (var key in Keys)
            {
                clone.Add(key, this[key]);
            }
            return clone;
        }
    }
}
