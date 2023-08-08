using BOOKWEB.Data;
using BOOKWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOKWEB.Controllers
{
    public class RegisterController : Controller
    {
        BookDbContext bookDbContext;
        public RegisterController(Data.BookDbContext _bookDbContext)
        {
            this.bookDbContext = _bookDbContext;
        }
        public IActionResult FormRegisterProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormRegisterProfile(User obj)
        {
            User user = null;

            var _user = bookDbContext.Users.Add(obj);
            user = _user.Entity;

            bookDbContext.SaveChanges();

            return RedirectToAction("FormRegisterAccount", user);
        } 

        public IActionResult FormRegisterAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormRegisterAccount(Account obj)
        {
            Account account = null;
            //
            obj.CategoryRoleID = bookDbContext.CategoryRoles.Where(r => r.CategoryRoleId == 2).FirstOrDefault();

            var _account = bookDbContext.Accounts.Add(obj);
            bookDbContext.SaveChanges();

            return RedirectToAction("FormLogin", "Login", account);
        }
    }
}
