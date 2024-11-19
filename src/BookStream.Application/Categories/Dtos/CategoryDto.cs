

namespace BookStream.Application.Categories.Dtos
{
    /// <summary>
    /// Category
    /// </summary>
    public class CategoryDto
    {
        /// <summary>
        /// The unique identifier for the category
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the category
        /// </summary>
        public required string Name { get; set; }
    }
}