using System.Collections.Generic;
using System.Linq;
using library_manager.App.Models;
using library_manager.Infrastructure;

namespace library_manager.App.Services
{
    public class BookService
    {
        private readonly DatabaseContext _databaseContext;
        
        public BookService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        
        public List<AuthorViewModel> GetAuthorViewModels()
        {
            var authors = _databaseContext.Author.ToList();
        
            return authors.Select(author => new AuthorViewModel
            {
                Firstname = author.Firstname,
                LastName = author.LastName,
                AuthorId = author.AuthorId
            }).ToList();
        }

        public List<CategoryViewModel> GetCategoryViewModels()
        {
            var categories = _databaseContext.Category.ToList();

            return categories.Select(category => new CategoryViewModel
            {
                CategoryName = category.CategoryName,
                CategoryId = category.CategoryId
            }).ToList();
        }
    }
}