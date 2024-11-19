using BookStream.Application.Categories.Dtos;
using BookStream.Domain.Categories.Entities;

namespace BookStream.Application.Common.Interfaces.Repositories
{
    /// <summary>
    /// Category repository
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Create a new category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<Guid> CreateCategoryAsync(Category category);

        /// <summary>
        /// Get a category by its unique identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CategoryDto> GetCategoryByIdAsync(Guid id);

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();

        /// <summary>
        /// Get all active categories
        /// </summary>
        /// <returns></returns>
        Task <IEnumerable<CategoryDto>> GetActiveCategoriesAsync();
    }
}