using System;
using System.Collections.Generic;
using System.Linq;
using library_manager.App.Models;
using library_manager.App.Services;
using library_manager.Domain;
using library_manager.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace library_manager.App.Controllers
{
    public class AddBookController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly BookService _bookService;
        
        public AddBookController(DatabaseContext databaseContext, BookService bookService)
        {
            _databaseContext = databaseContext;
            _bookService = bookService;
        }
        
        public IActionResult AddBookView()
        {
            var authorViewModels = _bookService.GetAuthorViewModels();
            var categoryViewModels = _bookService.GetCategoryViewModels();
            
            var addBookViewModel = new AddBookViewModel
            {
                Authors = authorViewModels,
                Categories = categoryViewModels
            };

            return View(addBookViewModel);
        }

        [HttpPost]
        public IActionResult AddBook(AddBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var authorViewModels = _bookService.GetAuthorViewModels();
                var categoryViewModels = _bookService.GetCategoryViewModels();
            
                var addBookViewModel = new AddBookViewModel
                {
                    Authors = authorViewModels,
                    Categories = categoryViewModels
                };

                return View("AddBookView", addBookViewModel);
            }

            var book = new Book
            {
                BookName = model.BookName,
                Descriptions = model.Descriptions,
                AuthorId = Guid.Parse(model.AuthorId)
            };

            _databaseContext.Add(book);
            _databaseContext.SaveChanges();

            return RedirectToAction("BooksListView", "BooksList");
        }
    }
}