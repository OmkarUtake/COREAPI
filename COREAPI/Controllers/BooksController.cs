using COREAPI.DATA.ViewModel;
using COREAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COREAPI.Controllers
{
    [Route("Book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IBookService _bookservice;
        public BooksController(IBookService bookservice)
        {
            _bookservice = bookservice;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookViewModel book)
        {
            _bookservice.AddBook(book);
            return Ok();
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetBook()
        {
            var book = _bookservice.GetAllBooks();
            return Ok(book);
        }

        [HttpGet]
        [Route("getbookbyid/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookservice.GetBookById(id);
            return Ok(book);
        }

        [HttpPut("Updatebyid/{id}")]
        public IActionResult UpdateBook(int id, BookViewModel book)
        {
            _bookservice.UpdateBook(id, book);
            return Ok();
        }

        [HttpDelete("deletebyid/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookservice.DeleteBook(id);
            return Ok();
        }
    }
}
