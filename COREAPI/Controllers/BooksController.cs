
using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System;

namespace COREAPI.Controllers
{
    [Route("Book")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookservice;


        public BooksController(IBookService bookService)
        {
            _bookservice = bookService;
        }

        [HttpPost("AddNew")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _bookservice.AddBook(book);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetBook()
        {
            var book = _bookservice.GetAllBooks();
            return Ok(book);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetBookById(int id)
        {
            var nBook = _bookservice.GetBookById(id);
            return Ok(nBook);
        }

        [HttpPut("UpdateById/{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            _bookservice.UpdateBook(id, book);
            return Ok();
        }

        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookservice.DeleteBook(id);
            return Ok();
        }

        [HttpGet("SearchByName/{name}")]
        public IActionResult SearchByName(String name)
        {
            var book = _bookservice.SearchByName(name);
            return Ok(book);
        }
    }
}
