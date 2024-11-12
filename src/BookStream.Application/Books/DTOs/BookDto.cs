namespace BookStream.Application.Books.DTOs
{
    public class BookDto
    {
        /// <summary>
        /// BookId
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Title
        /// </summary>
        public required string Title { get; set; }
        
        /// <summary>
        /// Author
        /// </summary>
        public required string Author { get; set; }
        
        /// <summary>
        /// Category Id
        /// </summary>
        public required Guid CategoryId { get; set; }
        
        /// <summary>
        /// ISBN
        /// </summary>
        public required string ISBN { get; set;  }
        
        /// <summary>
        /// Description
        /// </summary>
        public required string Description { get; set; }
        
        /// <summary>
        /// PublishedDate
        /// </summary>
        public DateTime? PublishedDate { get; set; }
        
        /// <summary>
        /// CoverImageUrl
        /// </summary>
        public string? CoverImageUrl { get; set; }
        
        /// <summary>
        /// Create at date
        /// </summary>
        public DateTime CreateDat { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
    }
}