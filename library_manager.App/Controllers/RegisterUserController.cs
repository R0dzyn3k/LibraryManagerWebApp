using library_manager.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace library_manager.App.Controllers
{
    public class RegisterUserController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public RegisterUserController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        // [HttpPost]
        // public IActionResult AddBook(RegisterUserViewModel model)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return View("RegisterUserView");
        //     }
        //     
        //     var user = new User()
        //     {
        //         BookName = model.BookName,
        //         Descriptions = model.Descriptions
        //     };
        //
        //     _databaseContext.Add(Book);
        //     _databaseContext.SaveChanges();
        //
        //     return RedirectToAction("Index", "Home");
        // }
    }
}