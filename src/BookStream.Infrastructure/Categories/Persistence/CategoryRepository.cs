using BookStream.Application.Categories.Dtos;
using BookStream.Application.Common.Interfaces.Repositories;
using BookStream.Domain.Categories.Entities;

namespace BookStream.Infrastructure.Categories.Persistence
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Guid> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetActiveCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}