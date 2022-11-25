using Microsoft.AspNetCore.Mvc;
using MusicStore.Models.Data;
using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Data.Extensions;
using MusicStore.Models.Data.Repositories;
using MusicStore.Models.DTOs;
using MusicStore.Models.Grid;
using MusicStore.Models.ViewModel;

namespace MusicStore.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IMusicStoreUnitOfWork _data;

        public AlbumController(MusicStoreContext context)
        {
            _data = new MusicStoreUnitOfWork(context);
        }

        public RedirectToActionResult Index() => RedirectToAction("List");

        public ViewResult List(AlbumGridDTO values)
        {
            AlbumGridBuilder builder = new(HttpContext.Session, values, defaultSortField: nameof(Album.Title));

            AlbumQueryOptions options = new()
            {
                Includes = "Artists, Genre, AlbumType",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
            };

            options.SortFilter(builder);

            AlbumListViewModel vm = new()
            {
                Albums = _data.Albums.List(options),
                Artists = _data.Artists.List(new QueryOptions<Artist> { OrderBy = a => a.Name }),
                Genres = _data.Genres.List(new QueryOptions<Genre> { OrderBy = g => g.Name }),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(_data.Albums.Count),
            };

            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            AlbumGridBuilder builder = new(HttpContext.Session);

            if (clear)
            {
                builder.ClearFilterSegments();
            }
            else
            {
                Artist artist = _data.Artists.Get(filter[0].ToInt());
                builder.LoadFilterSegments(filter, artist);
            }

            builder.SaveRouteSegments();

            return RedirectToAction("List", builder.CurrentRoute);
        }
    }
}
