
using AutoMapper;
using CORE.Model.DTO;
using COREAPI.DATA;
using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace COREAPI.Controllers
{
    [Route("Book")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookservice;
        private readonly IMapper _mapper;


        public BooksController(IBookService bookService, IMapper mapper)
        {
            _bookservice = bookService;
            _mapper = mapper;
        }

        [HttpPost("AddNew")]
        public IActionResult AddBook([FromBody] BookDTO bookDTO)
        {
            var book = _mapper.Map<Book>(bookDTO);
            _bookservice.AddBook(book);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetBook()
        {
            Book book = (Book)_bookservice.GetAllBooks();
            return Ok(book);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetBookById(int id)
        {
            var Book = _bookservice.GetBookById(id);
            var bookDTO = _mapper.Map<BookDTO>(Book);
            return Ok(bookDTO);
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
