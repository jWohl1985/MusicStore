using Microsoft.AspNetCore.Mvc;
using MusicStore.Models.Data;
using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Data.Repositories;
using MusicStore.Models.DTOs;
using MusicStore.Models.Grid;
using MusicStore.Models.ViewModel;

namespace MusicStore.Controllers
{
    public class ArtistController : Controller
    {
        private readonly Repository<Artist> _artists;

        public ArtistController(MusicStoreContext context)
        {
            _artists = new Repository<Artist>(context);
        }

        public RedirectToActionResult Index() => RedirectToAction("List");

        public ViewResult List(GridDTO vals)
        {
            string defaultSort = nameof(Artist.Name);
            GridBuilder builder = new GridBuilder(HttpContext.Session, vals, defaultSort);

            QueryOptions<Artist> options = new QueryOptions<Artist>
            {
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
                OrderBy = a => a.Name,
                OrderByDirection = builder.CurrentRoute.SortDirection,
            };

            ArtistListViewModel vm = new ArtistListViewModel();
            vm.Artists = _artists.List(options);
            vm.CurrentRoute = builder.CurrentRoute;
            vm.TotalPages = builder.GetTotalPages(_artists.Count);

            return View(vm);
        }
    }
}
