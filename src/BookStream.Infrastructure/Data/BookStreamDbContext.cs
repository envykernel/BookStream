using BookStream.Domain.Books.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStream.Infrastructure.Data
{
    public class BookStreamDbContext : DbContext
    {
        public BookStreamDbContext(DbContextOptions<BookStreamDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Your_PostgreSQL_Connection_String_Here");
            }
        }
    }
}