using MusicStore.Models.DomainModels;
using MusicStore.Models.Grid;

namespace MusicStore.Models.ViewModel
{
    public class CartViewModel
    {
        public IEnumerable<CartItem> List { get; set; } = default!;
        public RouteDictionary AlbumGridRoute { get; set; } = default!;
        public double Subtotal { get; set; }
    }
}
