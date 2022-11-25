using MusicStore.Models.DomainModels;
using MusicStore.Models.DTOs;

namespace MusicStore.Models.ExtensionMethods
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list)
        {
            return list.Select(cartItem => new CartItemDTO
            {
                AlbumId = cartItem.Album.AlbumId,
                Quantity = cartItem.Quantity,
            }).ToList();
        }
    }
}
