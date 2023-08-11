using Azure;
using Azure.Messaging;
using BOOKWEB.Data;
using BOOKWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOKWEB.Controllers
{
    public class LoginController : Controller
    {
        BookDbContext bookDbContext;
        public LoginController(Data.BookDbContext _bookDbContext)
        {
            this.bookDbContext = _bookDbContext;
        }
        public IActionResult FormLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormLogin(Account obj)
        {
            Account account = null;
            Account _account = null;

            _account = bookDbContext.Accounts.Where
                (a => a.Usernames == obj.Usernames && a.Passwords == obj.Passwords).FirstOrDefault();
            
            if (_account == null)
            {
                ViewBag.Noti = "Dang nhap khong thanh cong";
                return View();
            }
            else {
                //add session

                return RedirectToAction("Index", "Home", account);
            }
        }
    }
}
