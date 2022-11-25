using System.Text.Json.Serialization;
using MusicStore.Models.DTOs;

namespace MusicStore.Models.DomainModels
{
    public class CartItem
    {
        public AlbumDTO Album { get; set; } = default!;
        public int Quantity { get; set; }

        [JsonIgnore]
        public decimal Subtotal => Album.Price * Quantity;
    }
}
