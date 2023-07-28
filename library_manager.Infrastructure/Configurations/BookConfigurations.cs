using library_manager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace library_manager.Infrastructure.Configurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("book");

            builder.HasKey(x => x.BookId);
            builder.Property(x => x.BookId)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.BookName)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Descriptions)
                .IsRequired();

            builder.Property(x => x.CategoryId)
                .IsRequired();

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.AuthorId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CategoryId);

            builder.HasData(DefaultData.GetAllBooks());
        }
    }
}