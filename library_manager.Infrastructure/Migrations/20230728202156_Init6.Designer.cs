﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using library_manager.Infrastructure;

namespace library_manager.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230728202156_Init6")]
    partial class Init6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("library_manager.Domain.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("author");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("3d577e44-8f9a-42c5-94a9-7ea59f5a5b2d"),
                            Firstname = "Adam",
                            LastName = "Sienkiewicz"
                        },
                        new
                        {
                            AuthorId = new Guid("9d54cf49-5b7b-4c5f-ab3c-8b227b6886de"),
                            Firstname = "Henryk",
                            LastName = "Mickiewicz"
                        },
                        new
                        {
                            AuthorId = new Guid("49a10878-472f-4574-9d1e-4a6613c5f456"),
                            Firstname = "Stanisław",
                            LastName = "Lem"
                        },
                        new
                        {
                            AuthorId = new Guid("b8d6a56c-5424-41c8-b634-be6c47f5b795"),
                            Firstname = "J.K.",
                            LastName = "Rowling"
                        },
                        new
                        {
                            AuthorId = new Guid("cc81a20c-bf12-400f-b6a6-8ae6d3b6b857"),
                            Firstname = "George",
                            LastName = "Orwell"
                        },
                        new
                        {
                            AuthorId = new Guid("39f22b16-3536-42eb-8251-1e5f54bcc7d3"),
                            Firstname = "Ernest",
                            LastName = "Hemingway"
                        },
                        new
                        {
                            AuthorId = new Guid("717ec5a2-fc14-414d-8d9e-0740895d065b"),
                            Firstname = "Jane",
                            LastName = "Austen"
                        },
                        new
                        {
                            AuthorId = new Guid("618c8a59-fc69-4a8a-8960-79e1a9d250e8"),
                            Firstname = "Fyodor",
                            LastName = "Dostoevsky"
                        },
                        new
                        {
                            AuthorId = new Guid("4a6e7a70-3aef-4fcd-91c9-441eaec4a14b"),
                            Firstname = "William",
                            LastName = "Shakespeare"
                        },
                        new
                        {
                            AuthorId = new Guid("2b02afa9-73b7-4e88-b20a-72fb9f63fcb7"),
                            Firstname = "Charles",
                            LastName = "Dickens"
                        },
                        new
                        {
                            AuthorId = new Guid("90da96c8-0964-4c94-a92c-3c20f5dfe9e2"),
                            Firstname = "Leo",
                            LastName = "Tolstoy"
                        },
                        new
                        {
                            AuthorId = new Guid("843ef8e3-3c9f-4c6f-a9f3-1e7c105aa892"),
                            Firstname = "Mark",
                            LastName = "Twain"
                        },
                        new
                        {
                            AuthorId = new Guid("1b8048ed-dba2-43a7-8d95-7c60c67ef86f"),
                            Firstname = "Stephen",
                            LastName = "King"
                        },
                        new
                        {
                            AuthorId = new Guid("ca1f4f3e-74d1-4e4a-9772-7e1fb4476c1e"),
                            Firstname = "Agatha",
                            LastName = "Christie"
                        },
                        new
                        {
                            AuthorId = new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"),
                            Firstname = "J.R.R.",
                            LastName = "Tolkien"
                        },
                        new
                        {
                            AuthorId = new Guid("1c6e75fe-9912-4e78-8f6d-cbf3a6b83d8f"),
                            Firstname = "George",
                            LastName = "Martin"
                        },
                        new
                        {
                            AuthorId = new Guid("7819f6a2-db6c-4679-80d2-ec2a2c442a39"),
                            Firstname = "Dan",
                            LastName = "Brown"
                        },
                        new
                        {
                            AuthorId = new Guid("33f7e4d7-fa3f-4d5a-9c90-af28fdf6fea8"),
                            Firstname = "Paulo",
                            LastName = "Coelho"
                        },
                        new
                        {
                            AuthorId = new Guid("3b03f0c9-e5c1-4acd-a0a2-77b1d9e5b4c8"),
                            Firstname = "Harper",
                            LastName = "Lee"
                        },
                        new
                        {
                            AuthorId = new Guid("0d4628c4-6a42-46ea-9637-109e9fe46d9f"),
                            Firstname = "Emily",
                            LastName = "Bronte"
                        });
                });

            modelBuilder.Entity("library_manager.Domain.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("book");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("11223344-5566-7788-99aa-bbccddeeff00"),
                            AuthorId = new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"),
                            BookName = "Hobbit",
                            CategoryId = new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"),
                            Descriptions = "An adventure of a lovable hobbit and his friends, set in the fantastical Middle-Earth."
                        },
                        new
                        {
                            BookId = new Guid("22334455-6677-8899-aabb-ccddeeff0011"),
                            AuthorId = new Guid("cc81a20c-bf12-400f-b6a6-8ae6d3b6b857"),
                            BookName = "1984",
                            CategoryId = new Guid("6d7cfe13-8efe-4d0a-b8d6-3cde44b7b523"),
                            Descriptions = "A dystopian novel about a future totalitarian society."
                        },
                        new
                        {
                            BookId = new Guid("33445566-7788-99aa-bbcc-ddeeff001122"),
                            AuthorId = new Guid("cc81a20c-bf12-400f-b6a6-8ae6d3b6b857"),
                            BookName = "Animal Farm",
                            CategoryId = new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"),
                            Descriptions = "A political satire and allegory that reflects events leading up to the Russian Revolution."
                        },
                        new
                        {
                            BookId = new Guid("44556677-8899-aabb-ccdd-eeff00112233"),
                            AuthorId = new Guid("b8d6a56c-5424-41c8-b634-be6c47f5b795"),
                            BookName = "Harry Potter",
                            CategoryId = new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"),
                            Descriptions = "A series about a young wizard's journey to fulfill his destiny in a world filled with magic."
                        },
                        new
                        {
                            BookId = new Guid("55667788-99aa-bbcc-ddee-ff0011223344"),
                            AuthorId = new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"),
                            BookName = "The Lord of the Rings",
                            CategoryId = new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"),
                            Descriptions = "An epic fantasy trilogy about the fight against the dark lord Sauron."
                        },
                        new
                        {
                            BookId = new Guid("66778899-aabb-ccdd-eeff-001122334455"),
                            AuthorId = new Guid("3b03f0c9-e5c1-4acd-a0a2-77b1d9e5b4c8"),
                            BookName = "To Kill a Mockingbird",
                            CategoryId = new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"),
                            Descriptions = "A stirring exploration of human morality, depicted through the perspective of a young girl in the Deep South."
                        },
                        new
                        {
                            BookId = new Guid("778899aa-bbcc-ddee-ff00-112233445566"),
                            AuthorId = new Guid("b8d6a56c-5424-41c8-b634-be6c47f5b795"),
                            BookName = "The Great Gatsby",
                            CategoryId = new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"),
                            Descriptions = "A critique of the American Dream set in the backdrop of roaring twenties."
                        },
                        new
                        {
                            BookId = new Guid("8899aabb-ccdd-eeff-0011-223344556677"),
                            AuthorId = new Guid("717ec5a2-fc14-414d-8d9e-0740895d065b"),
                            BookName = "The Catcher in the Rye",
                            CategoryId = new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"),
                            Descriptions = "A novel that perfectly captures teenage angst, rebellion, and feelings of isolation."
                        },
                        new
                        {
                            BookId = new Guid("99aabbcc-ddee-ff00-1122-334455667788"),
                            AuthorId = new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"),
                            BookName = "A Game of Thrones",
                            CategoryId = new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"),
                            Descriptions = "A political intrigue set in a fantasy world with a cast of complex characters and intricate plot lines."
                        },
                        new
                        {
                            BookId = new Guid("aabbccdd-eeff-0011-2233-445566778899"),
                            AuthorId = new Guid("717ec5a2-fc14-414d-8d9e-0740895d065b"),
                            BookName = "Pride and Prejudice",
                            CategoryId = new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"),
                            Descriptions = "A classic romantic novel that explores the themes of love, marriage, and social standings in the 19th century England."
                        },
                        new
                        {
                            BookId = new Guid("bbccddee-ff00-1122-3344-5566778899aa"),
                            AuthorId = new Guid("7819f6a2-db6c-4679-80d2-ec2a2c442a39"),
                            BookName = "The Da Vinci Code",
                            CategoryId = new Guid("6a7f5123-4c8e-4fa4-9931-9a4663d215b2"),
                            Descriptions = "A gripping thriller that combines art, history, and religion in an intricate conspiracy theory."
                        },
                        new
                        {
                            BookId = new Guid("ccddeeff-0011-2233-4455-66778899aabb"),
                            AuthorId = new Guid("9d54cf49-5b7b-4c5f-ab3c-8b227b6886de"),
                            BookName = "Moby Dick",
                            CategoryId = new Guid("3806a2ac-7eba-4a9a-9f34-ac6c403313bd"),
                            Descriptions = "A tale of obsession and revenge set in the backdrop of a perilous whaling expedition."
                        },
                        new
                        {
                            BookId = new Guid("ddeeff00-1122-3344-5566-778899aabbcc"),
                            AuthorId = new Guid("3d577e44-8f9a-42c5-94a9-7ea59f5a5b2d"),
                            BookName = "The Hunger Games",
                            CategoryId = new Guid("6d7cfe13-8efe-4d0a-b8d6-3cde44b7b523"),
                            Descriptions = "A young girl's fight for survival in a dystopian future where children are forced to fight to the death in a televised event."
                        },
                        new
                        {
                            BookId = new Guid("eeff0011-2233-4455-6677-8899aabbccdd"),
                            AuthorId = new Guid("1b8048ed-dba2-43a7-8d95-7c60c67ef86f"),
                            BookName = "IT",
                            CategoryId = new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"),
                            Descriptions = "A horror tale about seven children who are terrorized by an evil entity that exploits their fears and phobias."
                        },
                        new
                        {
                            BookId = new Guid("ff001122-3344-5566-7788-99aabbccddee"),
                            AuthorId = new Guid("1b8048ed-dba2-43a7-8d95-7c60c67ef86f"),
                            BookName = "The Shining",
                            CategoryId = new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"),
                            Descriptions = "A chilling tale of a family torn apart by the sinister forces in an isolated hotel during winter."
                        });
                });

            modelBuilder.Entity("library_manager.Domain.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("category");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"),
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = new Guid("6d7cfe13-8efe-4d0a-b8d6-3cde44b7b523"),
                            CategoryName = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = new Guid("2ec4fe1c-db01-4ec1-9755-0af292a8c7f0"),
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryId = new Guid("6a7f5123-4c8e-4fa4-9931-9a4663d215b2"),
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = new Guid("956f2527-9d0e-40c8-9658-8727f78e6e64"),
                            CategoryName = "Biography"
                        },
                        new
                        {
                            CategoryId = new Guid("a6aafd42-5679-4e8e-8e8b-25cdf483c767"),
                            CategoryName = "History"
                        },
                        new
                        {
                            CategoryId = new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"),
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = new Guid("3806a2ac-7eba-4a9a-9f34-ac6c403313bd"),
                            CategoryName = "Kids"
                        },
                        new
                        {
                            CategoryId = new Guid("5e23987c-4e70-46d6-b971-f8a9ac1cb7f2"),
                            CategoryName = "Young Adult"
                        },
                        new
                        {
                            CategoryId = new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"),
                            CategoryName = "Non-Fiction"
                        });
                });

            modelBuilder.Entity("library_manager.Domain.Book", b =>
                {
                    b.HasOne("library_manager.Domain.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("library_manager.Domain.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("library_manager.Domain.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("library_manager.Domain.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
