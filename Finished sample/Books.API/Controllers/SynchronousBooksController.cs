using Books.API.Services; 
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Controllers;

[Route("api")]
[ApiController]
public class SynchronousBooksController(IBooksRepository booksRepository) : ControllerBase
{
    private readonly IBooksRepository _booksRepository = booksRepository ??
            throw new ArgumentNullException(nameof(booksRepository));

    [HttpGet("books/sync")]
    public IActionResult GetBooks()
    {
        var bookEntities = _booksRepository.GetBooks();
        return Ok(bookEntities);
    }
}
