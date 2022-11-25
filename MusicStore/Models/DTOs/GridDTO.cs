namespace MusicStore.Models.DTOs
{
    public class GridDTO
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public string SortField { get; set; } = default!;
        public string SortDirection { get; set; } = "asc";
    }
}
