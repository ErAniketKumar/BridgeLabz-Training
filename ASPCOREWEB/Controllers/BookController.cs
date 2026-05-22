using ASPCOREWEB.Data;
using ASPCOREWEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCOREWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public readonly AppDbContext _db;

        public BookController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Books book)
        {
            if (book == null)
            {
                return BadRequest("Book data is empty!");
            }

            await _db.BooksTable.AddAsync(book);
            await _db.SaveChangesAsync();

            return Ok(book);
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _db.BooksTable.ToList();
            if(books==null)
            {
                return NotFound("Books not found!");
            }

            return Ok(books);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Books book)
        {
            var item = _db.BooksTable.Find(id);
            if (item == null)
            {
                return NotFound("Book not found!");
            }

            item.Title = book.Title;
            item.Author = book.Author;
            item.Price = book.Price;
            item.Pages = book.Pages;
            item.IsPublished = book.IsPublished;

            _db.SaveChanges();

            return Ok(item);
        }

        [HttpGet("{id}")]
        public IActionResult GetABook(int id)
        {
            var book = _db.BooksTable.Find(id);
            if(book==null)
            {
                return NotFound("Book not found!");
            }
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _db.BooksTable.Find(id);

            if (book == null)
            {
                return NotFound("Book not found");
            }

            _db.BooksTable.Remove(book);
            _db.SaveChanges();

            return Ok(book);
        }
    }
}
