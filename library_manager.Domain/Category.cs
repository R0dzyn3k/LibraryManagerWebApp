using System;
using System.Collections.Generic;

namespace library_manager.Domain
{
    public class Category
    {
        public Guid CategoryId { set; get; }
        public string CategoryName { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }

    }
}