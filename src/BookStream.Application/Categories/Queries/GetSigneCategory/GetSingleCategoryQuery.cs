using BookStream.Application.Categories.Dtos;
using BookStream.Domain.Common.ResultPattern;

namespace BookStream.Application.Categories.Queries.GetSigneCategory
{
    public class GetSingleCategoryQuery:IRequest<Result<CategoryDto>>
    {
        public Guid Id { get; set; }
    }
}