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

        public IActionResult Read(int bookID)
        {
            Book book = bookDbContext.Books.FirstOrDefault(b => b.BookId == bookID);

            return View(book);
        }
    }
}
