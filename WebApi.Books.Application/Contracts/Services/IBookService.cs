using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Books.Application.Services.Books;
using WebApi.Books.Domain.Entities;

namespace WebApi.Books.Application.Contracts.Services
{
    public interface IBookService
    {
        public Task<List<Book>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> Add(BookRequestDto newBook);
        public Task<Book> Update(int id, BookRequestDto newBook);
        public Task<Book> Delete(int id);
    }
}
