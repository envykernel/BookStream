using AutoMapper;
using BookStream.Application.Books.DTOs;
using BookStream.Application.Books.Interfaces;
using BookStream.Application.Common.Interfaces.Repositories;
using BookStream.Domain.Books.Entities;
using Microsoft.Extensions.Logging;

namespace BookStream.Application.Books.Services
{
    public class BookService : IBookService
    {
        private readonly ILogger<BookService> _logger;
        private readonly IBookRepository _bookRepository;

        private readonly IMapper _mapper;

        BookService(ILogger<BookService> logger, IBookRepository bookRepository, IMapper mapper)
        {
            _logger = logger;
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(BookDto book)
        {
           await _bookRepository.AddAsync(_mapper.Map<Book>(book));
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(BookDto book)
        {
            throw new NotImplementedException();
        }
    }
}