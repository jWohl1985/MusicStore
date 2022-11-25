using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.DTOs
{
    public class AlbumDTO
    {
        public int AlbumId { get; set; }
        public string Title { get; set; } = default!;
        public decimal Price { get; set; }
        public Dictionary<int, string> Artists { get; set; } = default!;

        public void Load(Album album)
        {
            AlbumId = album.Id;
            Title = album.Title;
            Price = album.Price;
            Artists = new Dictionary<int, string>();

            foreach(Artist artist in album.Artists)
            {
                Artists.Add(artist.Id, artist.Name);
            }
        }
    }
}
