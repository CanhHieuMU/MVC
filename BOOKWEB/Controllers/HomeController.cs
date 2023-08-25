using BOOKWEB.Data;
using BOOKWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BOOKWEB.Controllers
{
    public class HomeController : Controller
    {
        BookDbContext bookDbContext;
        private readonly ILogger<HomeController> _logger;
        public HomeController(Data.BookDbContext _bookDbContext)
        {
            this.bookDbContext = _bookDbContext;
        }
        public IActionResult Index()
        {
            //gán danh sách cho biến b 
            var b = bookDbContext.Books.ToList();
            
            return View(b);
        }

        public IActionResult FormBook(int bookID)
        {
            Book book = bookDbContext.Books.FirstOrDefault(b => b.BookId == bookID);
            var listCategories = bookDbContext.Books.Where(boo => boo.BookId == bookID).SelectMany(b => b.CategoryBooks).ToList();
            book.CategoryBooks = listCategories;

            return View(book);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}