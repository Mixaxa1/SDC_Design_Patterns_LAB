using Microsoft.AspNetCore.Mvc;
using Task3v2ApiSide.ApiSide.BookStorageSystem;

namespace Task3v2ApiSide.ApiSide.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookStorageController : ControllerBase
    {
        private IBookStorage _bookStorage {  get; set; }

        public BookStorageController(IBookStorage bookStorage)
        {
            _bookStorage = bookStorage;
        }

        [HttpGet("{title}")]
        public IActionResult GetByTitle(string title)
        {
            return Ok(_bookStorage.GetBook(title));
        }
    }
}
