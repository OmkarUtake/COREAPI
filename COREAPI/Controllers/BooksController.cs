using BuisnessLayer.Services.AddBook;
using BuisnessLayer.Services.DeleteBook;
using BuisnessLayer.Services.GetBook;
using BuisnessLayer.Services.UpdateBook;
using COREAPI.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace COREAPI.Controllers
{
    [Route("Book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IPostBook _AddBook;
        private readonly IGetBookById _bookdetail;
        private readonly IUpdateBook _updateBook;
        private readonly IDeleteBook _deleteBook;
        public BooksController(IPostBook AddBook, IGetBookById getbookdetail, IUpdateBook updateBook, IDeleteBook deleteBook)
        {
            _AddBook = AddBook;
            _bookdetail = getbookdetail;
            _updateBook = updateBook;
            _deleteBook = deleteBook;
        }


        [HttpPost]
        public IActionResult AddBook([FromBody] BookViewModel book)
        {
            _AddBook.AddBook(book);
            return Ok();
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetBook()
        {
            var book = _bookdetail.GetAllBooks();
            return Ok(book);
        }

        [HttpGet]
        [Route("getbookbyid/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookdetail.GetBookById(id);
            return Ok(book);
        }

        [HttpPut("Updatebyid/{id}")]
        public IActionResult UpdateBook(int id, BookViewModel book)
        {
            _updateBook.EditDetail(id, book);
            return Ok();
        }

        [HttpDelete("deletebyid/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _deleteBook.RemoveBook(id);
            return Ok();
        }
    }
}
