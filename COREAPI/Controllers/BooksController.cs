
using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace COREAPI.Controllers
{
    [Route("Book")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookRepository _bookservice;


        public BooksController(IBookRepository bookService)
        {
            _bookservice = bookService;
        }

        [HttpPost("AddNew")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _bookservice.Add(book);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetBook()
        {
            var book = _bookservice.GetAll();
            return Ok(book);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetBookById(int id)
        {
            var nBook = _bookservice.GetById(x => x.Id == id);
            return Ok(nBook);
        }

        [HttpPut("UpdateById/{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            _bookservice.Update(id, book);
            return Ok();
        }

        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookservice.Delete(x => x.Id == id);
            return Ok();
        }

        [HttpGet("SearchByName/{name}")]
        public IActionResult SearchByName(String name)
        {
            var book = _bookservice.SearchBookByName(name);
            return Ok(book);
        }
    }
}
