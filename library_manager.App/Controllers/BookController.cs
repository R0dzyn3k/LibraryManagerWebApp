using System;
using System.Linq;
using library_manager.App.Models;
using library_manager.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace library_manager.app.Controllers
{
    public class BookController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public BookController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpPost]
        public IActionResult BookView(Guid id)
        {
            var book = _databaseContext.Books.FirstOrDefault(x => x.BookId == id);

            return View(new BookViewModel
            {
                BookName = book.BookName,
                Descriptions = book.Descriptions,
                Category = _databaseContext.Category.FirstOrDefault(x => x.CategoryId == book.CategoryId)
                    ?.CategoryName,
                Author = _databaseContext.Author.FirstOrDefault(x => x.AuthorId == book.AuthorId)?.Firstname + " " +
                         _databaseContext.Author.FirstOrDefault(x => x.AuthorId == book.AuthorId)?.LastName
            });
       }
    }
}