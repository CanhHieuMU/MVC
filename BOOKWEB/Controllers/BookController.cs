using BOOKWEB.Data;
using BOOKWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOKWEB.Controllers
{
    public class BookController : Controller
    {
        BookDbContext bookDbContext;
        public BookController(Data.BookDbContext bookDbContext) {
            this.bookDbContext = bookDbContext;
        }
        [HttpPost]
        public IActionResult FormBook(Book book)
        {
            return View(book);
        }
    }
}
