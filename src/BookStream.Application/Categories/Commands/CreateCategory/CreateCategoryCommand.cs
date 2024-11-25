using BookStream.Domain.Common.ResultPattern;

namespace BookStream.Application.Categories.Commands.CreateCategory
{
    public record CreateCategoryCommand:IRequest<Result<Guid>>
    {
        public required string Name { get; init; }
    }
}