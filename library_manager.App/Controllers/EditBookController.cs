using System;
using System.Linq;
using library_manager.App.Models;
using library_manager.App.Services;
using library_manager.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace library_manager.App.Controllers
{
    public class EditBookController :Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly BookService _bookService;

        public EditBookController(DatabaseContext databaseContext, BookService bookService)
        {
            _databaseContext = databaseContext;
            _bookService = bookService;
        }
        
        [HttpPost]
        public IActionResult EditBookView(Guid id) {
            var book = _databaseContext.Books.First(x => x.BookId == id);
            var authorViewModels = _bookService.GetAuthorViewModels();
            var categoryViewModels = _bookService.GetCategoryViewModels();

            return View("EditBookView", new EditBookViewModel
            {
                BookId = book.BookId.ToString(),
                BookName = book.BookName,
                Descriptions = book.Descriptions,
                CategoryId = book.CategoryId.ToString(),
                AuthorId = book.AuthorId.ToString(),
                
                Authors = authorViewModels,
                Categories = categoryViewModels,
            });
        }

        [HttpPost]
        public IActionResult SaveChanges(EditBookViewModel model)
        {
            var book = _databaseContext.Books.First(x => x.BookId == Guid.Parse(model.BookId));
    
            if (book != null)
            {
                book.BookName = model.BookName;
                book.Descriptions = model.Descriptions;
                book.CategoryId = Guid.Parse(model.CategoryId);
                book.AuthorId = Guid.Parse(model.AuthorId);
        
                _databaseContext.SaveChanges();
            }
    
            return RedirectToAction("BooksListView", "BooksList");
        }
    }
}