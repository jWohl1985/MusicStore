using System.Text;

namespace MusicStore.Models.Data.Extensions
{
    public static class StringExtensions
    {
        public static string Slug(this string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char character in s)
            {
                if(!char.IsPunctuation(character) || character == '-')
                {
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString().Replace(' ', '-').ToLower();
        }

        public static int ToInt(this string s)
        {
            int.TryParse(s, out int result);
            return result;
        }

        public static bool EqualsNoCase(this string s, string toCompare) => s.ToLower() == toCompare.ToLower();

        public static string Capitalize(this string s) => s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
    }
}
