using MusicStore.Models.Data.Extensions;
using MusicStore.Models.DTOs;

namespace MusicStore.Models.Grid
{
    public class GridBuilder
    {
        private const string RouteKey = "currentroute";

        protected RouteDictionary routes { get; set; }
        private ISession session { get; set; } = default!;

        // constructor used to get route data from session
        public GridBuilder(ISession sess)
        {
            session = sess;
            routes = session.GetObject<RouteDictionary>(RouteKey) ?? new RouteDictionary();
        }

        // constructor used when storing paging-sorting route segments
        public GridBuilder(ISession sess, GridDTO values, string defaultSortField)
        {
            session = sess;

            routes = new RouteDictionary();
            routes.PageNumber = values.PageNumber;
            routes.PageSize = values.PageSize;
            routes.SortField = values.SortField ?? defaultSortField;
            routes.SortDirection = values.SortDirection;

            SaveRouteSegments();
        }

        public void SaveRouteSegments() => session.SetObject<RouteDictionary>(RouteKey, routes);

        public int GetTotalPages(int count) => (count + routes.PageSize - 1) / routes.PageSize;

        public RouteDictionary CurrentRoute => routes;
    }
}
