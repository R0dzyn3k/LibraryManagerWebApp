using library_manager.Domain;
using library_manager.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace library_manager.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AuthorConfigurations().Configure(modelBuilder.Entity<Author>());
            new BookConfigurations().Configure(modelBuilder.Entity<Book>());
            new CategoryConfigurations().Configure(modelBuilder.Entity<Category>());
        }
    }
}