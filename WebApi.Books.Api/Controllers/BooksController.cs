using Microsoft.AspNetCore.Mvc;
using WebApi.Books.Application.Contracts.Services;
using WebApi.Books.Application.Services.Books;
using WebApi.Books.Domain.Entities;

namespace WebApi.Books.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var result = await _bookService.GetAllBooks();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var result = await _bookService.GetBookById(id);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook([FromBody] BookRequestDto book)
        {
            var result = await _bookService.Add(book);
            return result;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> UpdateBook(int id, [FromBody] BookRequestDto book)
        {
            var result = await _bookService.Update(id, book);
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> Delete(int id)
        {
            var result = await _bookService.Delete(id);
            return result;
        }
    }
}
