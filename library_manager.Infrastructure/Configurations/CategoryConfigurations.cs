using library_manager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace library_manager.Infrastructure.Configurations
{
    public class CategoryConfigurations: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category");

            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryId)
                .ValueGeneratedOnAdd()
                .IsRequired();
            
            builder.Property(x => x.CategoryName)
                .HasMaxLength(256)
                .IsRequired();
            
            builder.HasMany(x => x.Books)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            builder.HasData(DefaultData.GetAllCategories());
        }
    }
}