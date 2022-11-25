using System.Linq.Expressions;

namespace MusicStore.Models.Data
{
    public class QueryOptions<T>
    {
        public Expression<Func<T, Object>> OrderBy { get; set; } = null!;
        public string OrderByDirection { get; set; } = "asc";
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        private string[]? includes;
        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');
        }
        public string[] GetIncludes() => includes ?? new string[0];

        public WhereClauses<T> WhereClauses { get; set; } = null!;
        public Expression<Func<T, bool>> Where
        {
            set
            {
                if (WhereClauses is null)
                    WhereClauses = new WhereClauses<T>();

                WhereClauses.Add(value);
            }
        }

        public bool HasWhere => WhereClauses != null;
        public bool HasOrderBy => OrderBy != null;
        public bool HasPaging => PageNumber > 0 && PageSize > 0;
    }

    public class WhereClauses<T> : List<Expression<Func<T, bool>>> { }
}
