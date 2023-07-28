using System;
using System.Linq;
using library_manager.App.Models;
using library_manager.App.Services;
using library_manager.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace library_manager.App.Controllers
{
    public class BooksListController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public BooksListController(DatabaseContext databaseContext, BookService bookService)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult BooksListView(int pageIndex = 1, int pageSize = 10)
        {
            var books = _databaseContext
                .Books
                .OrderBy(b => b.BookName)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            
            var categories = _databaseContext.Category.ToList();
            var authors = _databaseContext.Author.ToList();

            var model = books.Select(book => new BooksListViewModel
            {
                BookId = book.BookId,
                BookName = book.BookName
            }).ToList();

            ViewBag.CurrentPage = pageIndex;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalCount = _databaseContext.Books.Count();

            int totalPages = (int)Math.Ceiling((double?)(ViewBag.TotalCount ?? 0) / (ViewBag.PageSize ?? 1));
            ViewBag.TotalPages = totalPages;

            return View(model);
        }
        
        [HttpPost]
        public IActionResult RemoveBookForm(Guid id)
        {
            var book = _databaseContext.Books.First(x => x.BookId == id);
            _databaseContext.Remove(book);
            _databaseContext.SaveChanges();

            return RedirectToAction("BooksListView");
        }
    }
}