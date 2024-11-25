namespace BookStream.Web.Categories.Dtos
{
    public class GetAllActiveCategoriesWithPaginationRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}