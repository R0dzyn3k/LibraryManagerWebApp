using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace library_manager.App.Models
{
    public class EditBookViewModel
    {
        public string BookId { get; set; } 
        [Required(ErrorMessage = "Please enter a book name.")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Please enter a book descriptions.")]
        public string Descriptions { get; set; }
        
        [Required]
        public string AuthorId { get; set; }
        [Required]
        public string CategoryId { get; set; }
        
        public List<AuthorViewModel> Authors { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        
        public int PageIndex { get; set; }
    }
}