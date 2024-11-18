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

        public Category(Guid id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}