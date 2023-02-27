
using COREAPI.DATA;
using DALayer.IRepository;
using DALayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System;
using System.Globalization;

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
            // _bookservice.AddBook(book);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetBook()
        {
            var book = _bookservice.GetAll();
            return Ok(book);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookservice.GetById(id);
            return Ok(book);
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
            _bookservice.Delete(id);
            return Ok();
        }


        [HttpGet("SearchById/{name}")]
        public IActionResult SearchByName(String name)
        {
            var book = _bookservice.SearchBookByName(name);
            return Ok(book);
        }
    }
}
