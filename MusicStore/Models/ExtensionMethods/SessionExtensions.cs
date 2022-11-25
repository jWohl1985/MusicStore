using Newtonsoft.Json;

namespace MusicStore.Models.Data.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T? GetObject<T>(this ISession session, string key)
        {
            string? value = session.GetString(key);

            if (value is null)
                return default(T);
            else
                return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
