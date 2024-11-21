using BookStream.Application.Categories.Dtos;
using BookStream.Application.Common.Interfaces.Repositories;
using BookStream.Domain.Categories.Entities;
using BookStream.Infrastructure.Categories.Persistence.Models;

namespace BookStream.Infrastructure.Categories.Persistence
{
    public class CategoryRepository : ICategoryRepository
    {
         private readonly Supabase.Client _supabaseClient;

        public CategoryRepository(Supabase.Client supabaseClient)
        {
            _supabaseClient = supabaseClient;
        }

        public async Task<Guid> CreateCategoryAsync(Category category)
        {
            try
            {
                var result = await _supabaseClient.From<CategoryModel>().Insert(new CategoryModel
                {
                    Id = category.Id,
                    Title = category.Name,
                    IsActive = category.IsActive,
                    CreatedAt = category.CreatedAt,
                    ModifiedAt = category.ModifiedAt,
                    CreatedBy = category.CreatedBy,
                    ModifiedBy = category.ModifiedBy
                });

                var insertedCategory = result.Models.FirstOrDefault();

                return insertedCategory!=null?insertedCategory.Id:throw new Exception("Category not created");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

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