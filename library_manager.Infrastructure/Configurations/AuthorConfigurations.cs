using System.Collections.Generic;
using library_manager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace library_manager.Infrastructure.Configurations
{
    public class AuthorConfigurations : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("author");

            builder.HasKey(x => x.AuthorId);
            builder.Property(x => x.AuthorId).ValueGeneratedOnAdd();

            builder.Property(x => x.Firstname).IsRequired();
            builder.Property(x => x.LastName).IsRequired();

            builder.HasMany(x => x.Books)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorId);

            builder.HasData(DefaultData.GetAllAuthors());
        }
    }
}