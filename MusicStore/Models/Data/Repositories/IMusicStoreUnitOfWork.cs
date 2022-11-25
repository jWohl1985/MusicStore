using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.Repositories
{
    public interface IMusicStoreUnitOfWork
    {
        Repository<Artist> Artists { get; }
        Repository<Album> Albums { get; }
        Repository<Genre> Genres { get; }
        Repository<AlbumType> AlbumTypes { get; }

        void AddAlbumArtists(Album album, int[] artistIds);
        void DeleteAlbumArtists(Album album);
        void Save();
    }
}
