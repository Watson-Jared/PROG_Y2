using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookLibrary;


namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly BookService _service;

        public BookController(BookService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Book> GetByID(int id)
        {
            var book = _service.GetById(id);
            return book is null ? NotFound() : Ok(book);
        }

        public ActionResult<Book> Add(Book book)
        {
            var created = _service.Add(book);
            return book is null ? NotFound() : Ok(book);
        }

        public ActionResult<Book> Delete(int id)
        {

            return _service.Delete(id) ? NoContent() : NotFound();
        }

    }
}
