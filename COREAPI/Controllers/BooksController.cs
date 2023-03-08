
using AutoMapper;
using CORE.Model.DTO;
using COREAPI.DATA;
using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System;
using System.Threading.Tasks;

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
        public async Task<IActionResult> AddBook([FromBody] BookDTO bookDTO)
        {
            var book = _mapper.Map<Book>(bookDTO);
            await _bookservice.AddBook(book);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetBook()
        {
            var book = await _bookservice.GetAllBooks();
            return Ok(book);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var Book = await _bookservice.GetBookById(id);
            if (Book == null)
            {
                throw new Exception("Please Enter valid id");
            }
            var bookDTO = _mapper.Map<BookDTO>(Book);
            return Ok(bookDTO);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            await _bookservice.UpdateBook(id, book);
            return Ok();
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookservice.DeleteBook(id);
            return Ok();
        }

        [HttpGet("SearchByName/{name}")]
        public async Task<IActionResult> SearchByName(String name)
        {
            var book = await _bookservice.SearchByName(name);
            return Ok(book);
        }
    }
}
 