using BookStream.Domain.Categories.Specifications;
using BookStream.Domain.Common.Interfaces;

namespace BookStream.Domain.Categories.Entities
{
    /// <summary>
    /// Category entity
    /// </summary>
    public class Category
    {
        /// <summary>
        /// The unique identifier for the category
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// The name of the category
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The status of the category
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Create a new category
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"></exception>
        public Category(string name)
        {
            var  nameSpecification = new ValidCategoryNameSpecification();
            if(!nameSpecification.IsSatisfiedBy(name))
            {
                throw new ArgumentException(nameSpecification.ErrorMessage);
            }

            Id = Guid.NewGuid();
            Name = name;
        }
        
    }
}