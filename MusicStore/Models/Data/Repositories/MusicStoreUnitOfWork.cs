using MusicStore.Models.Data.DomainModels;

namespace MusicStore.Models.Data.Repositories
{
    public class MusicStoreUnitOfWork : IMusicStoreUnitOfWork
    {
        private readonly MusicStoreContext _context;

        public MusicStoreUnitOfWork(MusicStoreContext context)
        {
            _context = context;
        }

        private Repository<Artist> artistData = default!;
        public Repository<Artist> Artists
        {
            get
            {
                if (artistData is null)
                    artistData = new Repository<Artist>(_context);

                return artistData;
            }
        }

        private Repository<Album> albumData = default!;
        public Repository<Album> Albums
        {
            get
            {
                if (albumData is null)
                    albumData = new Repository<Album>(_context);

                return albumData;
            }
        }

        private Repository<Genre> genreData = default!;
        public Repository<Genre> Genres
        {
            get
            {
                if (genreData is null)
                    genreData = new Repository<Genre>(_context);

                return genreData;
            }
        }

        private Repository<AlbumType> albumTypeData = default!;
        public Repository<AlbumType> AlbumTypes
        {
            get
            {
                if (albumTypeData is null)
                    albumTypeData = new Repository<AlbumType>(_context);

                return albumTypeData;
            }
        }

        public void AddAlbumArtists(Album album, int[] artistIds)
        {
           foreach(int id in artistIds)
           {
                Artist? artist = Artists.Get(id);

                if (artist is null)
                    continue;

                album.Artists.Add(artist);
           }
        }

        public void DeleteAlbumArtists(Album album)
        {
            album.Artists.Clear();
        }

        public void Save() => _context.SaveChanges();
    }
}
