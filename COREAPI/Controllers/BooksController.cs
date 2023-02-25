
using COREAPI.DATA;
using DALayer;
using Microsoft.AspNetCore.Mvc;

namespace COREAPI.Controllers
{
    [Route("Book")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IRepository<Book> _repo;


        public BooksController(IRepository<Book> repository)
        {
            _repo = repository;


        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _repo.AddBook(book);
            _repo.Save();
            return Ok();
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetBook()
        {
            var book = _repo.GetAll();
            return Ok(book);
        }

        [HttpGet("getbookbyid/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _repo.GetBookById(id);
            return Ok(book);
        }

        [HttpPut("Updatebyid/{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            _repo.UpdateBook(book);
            _repo.Save();
            return Ok();
        }

        [HttpDelete("deletebyid/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _repo.DeleteBook(id);
            _repo.Save();
            return Ok();
        }
    }
}
