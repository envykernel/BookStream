
using BookStream.Application.Categories.Commands.CreateCategory;
using BookStream.Web.Categories.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStream.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController:ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly IMediator _mediator;

        public CategoriesController(ILogger<CategoriesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequestDto request)
        {
            var command = new CreateCategoryCommand{Name = request.Title};
            var categoryId = await _mediator.Send(command);
            return Ok(categoryId);
        }
    }
}