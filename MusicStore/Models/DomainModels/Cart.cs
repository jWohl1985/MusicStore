using MusicStore.Models.Data;
using MusicStore.Models.Data.DomainModels;
using MusicStore.Models.Data.Extensions;
using MusicStore.Models.Data.Repositories;
using MusicStore.Models.DTOs;
using MusicStore.Models.ExtensionMethods;

namespace MusicStore.Models.DomainModels
{
    public class Cart
    {
        private const string CartKey = "mycart";
        private const string CountKey = "mycount";

        private List<CartItem> items { get; set; } = null!;
        private List<CartItemDTO> storedItems { get; set; } = null!;

        private ISession session { get; set; }
        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public Cart(HttpContext ctx)
        {
            session = ctx.Session;
            requestCookies = ctx.Request.Cookies;
            responseCookies = ctx.Response.Cookies;
        }

        public void Load(Repository<Album> data)
        {
            items = session.GetObject<List<CartItem>>(CartKey) ?? new List<CartItem>();

            if (items is null)
            {
                items = new List<CartItem>();
                storedItems = requestCookies.GetObject<List<CartItemDTO>>(CartKey);
            }

            if (storedItems?.Count > items?.Count)
            {
                foreach(CartItemDTO storedItem in storedItems!)
                {
                    Album? album = data.Get(new QueryOptions<Album>
                    {
                        Includes = "Artists, Genre",
                        Where = a => a.Id == storedItem.AlbumId,
                    });

                    if (album is not null)
                    {
                        AlbumDTO dto = new();
                        dto.Load(album);

                        CartItem item = new CartItem
                        {
                            Album = dto,
                            Quantity = storedItem.Quantity
                        };

                        items!.Add(item);
                    }
                }

                Save(); 
            }
        }

        public decimal Subtotal => items.Sum(c => c.Subtotal);
        public int? Count => session.GetInt32(CountKey) ?? requestCookies.GetInt32(CountKey);
        public IEnumerable<CartItem> List => items;

        public CartItem GetById(int id) => items.FirstOrDefault(ci => ci.Album.AlbumId == id);

        public void Add(CartItem item)
        {
            var itemInCart = GetById(item.Album.AlbumId);

            if (itemInCart is null)
                items.Add(item);
            else
                itemInCart.Quantity += 1;
        }

        public void Edit(CartItem item)
        {
            var itemInCart = GetById(item.Album.AlbumId);

            if (itemInCart is not null)
            {
                itemInCart.Quantity = item.Quantity;
            }
        }

        public void Remove(CartItem item) => items.Remove(item);

        public void Clear() => items.Clear();

        public void Save()
        {
            if (items.Count == 0)
            {
                session.Remove(CartKey);
                session.Remove(CountKey);
                responseCookies.Delete(CartKey);
                responseCookies.Delete(CountKey);
            }
            else
            {
                session.SetObject<List<CartItem>>(CartKey, items);
                session.SetInt32(CountKey, items.Count);
                responseCookies.SetObject<List<CartItemDTO>>(CartKey, items.ToDTO());
                responseCookies.SetInt32(CountKey, items.Count);
            }
        }
    }
}
