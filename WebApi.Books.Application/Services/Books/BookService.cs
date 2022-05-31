using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Books.Application.Contracts.Repositories;
using WebApi.Books.Application.Contracts.Services;
using WebApi.Books.Domain.Entities;

namespace WebApi.Books.Application.Services.Books
{
    public class BookService : IBookService
    {
        private readonly IBaseRepository<Book> _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBaseRepository<Book> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<Book> Add(BookRequestDto newBook)
        {
            var book = _mapper.Map<Book>(newBook);
            var result = await _bookRepository.Add(book);
            return result;
        }

        public async Task<Book> Delete(int id)
        {
            var book = await _bookRepository.GetById(id);

            if (book == null)
                throw new Exception($"Book with id = {id} doesn't exists.");

            var result = await _bookRepository.Delete(book);

            return result;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var result = await _bookRepository.GetAll();
            return result.ToList();
        }

        public async Task<Book> GetBookById(int id)
        {
            var result = await _bookRepository.GetById(id);

            if (result == null)
                throw new Exception($"Book with id = {id} doesn't exists.");

            return result;
        }

        public async Task<Book> Update(int id, BookRequestDto newBook)
        {
            var book = await _bookRepository.GetById(id);

            if (book == null)
                throw new Exception($"Book with id = {id} doesn't exists.");

            _mapper.Map(newBook, book);

            var result = await _bookRepository.Update(book);

            return result;
        }
    }
}
