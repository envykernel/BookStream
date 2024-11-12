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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<Book>(entity=>{
              entity.ToTable("books");
              entity.HasKey(e=>e.Id);
              entity.Property(e=>e.Title).HasColumnName("title").IsRequired().HasMaxLength(100);
              entity.Property(e=>e.Author).HasColumnName("author").IsRequired().HasMaxLength(100);
              entity.Property(e=>e.PublishedDate).HasColumnName("published_date").HasColumnType("timestamp").IsRequired();
              entity.Property(e=>e.Price).HasColumnName("price").IsRequired();
          });
        }
    }
}