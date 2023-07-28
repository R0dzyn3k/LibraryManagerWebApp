using System;

namespace library_manager.Domain
{
    public class Book
    {
        public Guid BookId { set; get; }
        public string BookName { get; set; }
        public string Descriptions { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}