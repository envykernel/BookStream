
using BookStream.Application.Common.Interfaces.Repositories;
using BookStream.Domain.Categories.Entities;
using BookStream.Domain.Common.ResultPattern;
using Microsoft.Extensions.Logging;


namespace BookStream.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler:IRequestHandler<CreateCategoryCommand,Result<Guid>>
    {
        private readonly ILogger<CreateCategoryCommandHandler> _logger;
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ILogger<CreateCategoryCommandHandler> logger, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }
        
        public async Task<Result<Guid>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
           var category = new Category(request.Name);

           var result = await _categoryRepository.CreateCategoryAsync(category);

           return result;
        }
    }
    
}