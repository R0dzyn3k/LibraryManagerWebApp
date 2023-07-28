using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace library_manager.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BookName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    AuthorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Descriptions = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_book_author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("3d577e44-8f9a-42c5-94a9-7ea59f5a5b2d"), "Adam", "Sienkiewicz" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("0d4628c4-6a42-46ea-9637-109e9fe46d9f"), "Emily", "Bronte" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("3b03f0c9-e5c1-4acd-a0a2-77b1d9e5b4c8"), "Harper", "Lee" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("33f7e4d7-fa3f-4d5a-9c90-af28fdf6fea8"), "Paulo", "Coelho" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("7819f6a2-db6c-4679-80d2-ec2a2c442a39"), "Dan", "Brown" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("1c6e75fe-9912-4e78-8f6d-cbf3a6b83d8f"), "George", "Martin" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("ca1f4f3e-74d1-4e4a-9772-7e1fb4476c1e"), "Agatha", "Christie" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("1b8048ed-dba2-43a7-8d95-7c60c67ef86f"), "Stephen", "King" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("843ef8e3-3c9f-4c6f-a9f3-1e7c105aa892"), "Mark", "Twain" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("90da96c8-0964-4c94-a92c-3c20f5dfe9e2"), "Leo", "Tolstoy" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"), "J.R.R.", "Tolkien" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("4a6e7a70-3aef-4fcd-91c9-441eaec4a14b"), "William", "Shakespeare" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("618c8a59-fc69-4a8a-8960-79e1a9d250e8"), "Fyodor", "Dostoevsky" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("717ec5a2-fc14-414d-8d9e-0740895d065b"), "Jane", "Austen" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("39f22b16-3536-42eb-8251-1e5f54bcc7d3"), "Ernest", "Hemingway" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("cc81a20c-bf12-400f-b6a6-8ae6d3b6b857"), "George", "Orwell" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("b8d6a56c-5424-41c8-b634-be6c47f5b795"), "J.K.", "Rowling" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("49a10878-472f-4574-9d1e-4a6613c5f456"), "Stanisław", "Lem" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("9d54cf49-5b7b-4c5f-ab3c-8b227b6886de"), "Henryk", "Mickiewicz" });

            migrationBuilder.InsertData(
                table: "author",
                columns: new[] { "AuthorId", "Firstname", "LastName" },
                values: new object[] { new Guid("2b02afa9-73b7-4e88-b20a-72fb9f63fcb7"), "Charles", "Dickens" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("3806a2ac-7eba-4a9a-9f34-ac6c403313bd"), "Kids" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"), "Romance" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("a6aafd42-5679-4e8e-8e8b-25cdf483c767"), "History" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("956f2527-9d0e-40c8-9658-8727f78e6e64"), "Biography" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"), "Fantasy" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("2ec4fe1c-db01-4ec1-9755-0af292a8c7f0"), "Mystery" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("6d7cfe13-8efe-4d0a-b8d6-3cde44b7b523"), "Science Fiction" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("5e23987c-4e70-46d6-b971-f8a9ac1cb7f2"), "Young Adult" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("6a7f5123-4c8e-4fa4-9931-9a4663d215b2"), "Thriller" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"), "Non-Fiction" });

            migrationBuilder.CreateIndex(
                name: "IX_book_AuthorId",
                table: "book",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "author");
        }
    }
}
