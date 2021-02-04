using AutoMapper;
using Shop.App.DTO;
using Shop.App.Models;

namespace Shop.App.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           CreateMap<BookCreating, Book>();
           CreateMap<Book, BookRead>().ReverseMap();
        }
    }
}