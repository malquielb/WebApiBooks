using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Books.Application.Services.Books
{
    public class BookRequestDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTimeOffset PublicationDate { get; set; }
        public string ISBN { get; set; }
    }
}
