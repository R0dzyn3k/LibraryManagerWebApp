using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace library_manager.Domain
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

