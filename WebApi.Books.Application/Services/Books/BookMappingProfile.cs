using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Books.Domain.Entities;

namespace WebApi.Books.Application.Services.Books
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<BookRequestDto, Book>();
        }
    }
}
