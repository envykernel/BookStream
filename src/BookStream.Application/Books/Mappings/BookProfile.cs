using AutoMapper;
using BookStream.Application.Books.DTOs;
using BookStream.Domain.Books.Entities;

namespace BookStream.Application.Books.Mappings
{
    public class BookProfile:Profile
    {
      public BookProfile()
        {
            CreateMap<Book, BookDto>();
        }  
    }
}