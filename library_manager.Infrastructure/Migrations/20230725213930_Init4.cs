using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace library_manager.Infrastructure.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("11223344-5566-7788-99aa-bbccddeeff00"), new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"), "Hobbit", new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"), "An adventure of a lovable hobbit and his friends, set in the fantastical Middle-Earth." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("22334455-6677-8899-aabb-ccddeeff0011"), new Guid("cc81a20c-bf12-400f-b6a6-8ae6d3b6b857"), "1984", new Guid("6d7cfe13-8efe-4d0a-b8d6-3cde44b7b523"), "A dystopian novel about a future totalitarian society." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("33445566-7788-99aa-bbcc-ddeeff001122"), new Guid("cc81a20c-bf12-400f-b6a6-8ae6d3b6b857"), "Animal Farm", new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"), "A political satire and allegory that reflects events leading up to the Russian Revolution." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("44556677-8899-aabb-ccdd-eeff00112233"), new Guid("b8d6a56c-5424-41c8-b634-be6c47f5b795"), "Harry Potter", new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"), "A series about a young wizard's journey to fulfill his destiny in a world filled with magic." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("55667788-99aa-bbcc-ddee-ff0011223344"), new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"), "The Lord of the Rings", new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"), "An epic fantasy trilogy about the fight against the dark lord Sauron." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("66778899-aabb-ccdd-eeff-001122334455"), new Guid("3b03f0c9-e5c1-4acd-a0a2-77b1d9e5b4c8"), "To Kill a Mockingbird", new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"), "A stirring exploration of human morality, depicted through the perspective of a young girl in the Deep South." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("778899aa-bbcc-ddee-ff00-112233445566"), new Guid("b8d6a56c-5424-41c8-b634-be6c47f5b795"), "The Great Gatsby", new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"), "A critique of the American Dream set in the backdrop of roaring twenties." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("8899aabb-ccdd-eeff-0011-223344556677"), new Guid("717ec5a2-fc14-414d-8d9e-0740895d065b"), "The Catcher in the Rye", new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"), "A novel that perfectly captures teenage angst, rebellion, and feelings of isolation." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("99aabbcc-ddee-ff00-1122-334455667788"), new Guid("0f22d080-a5c1-4c42-bf54-3b6f9d97f22e"), "A Game of Thrones", new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"), "A political intrigue set in a fantasy world with a cast of complex characters and intricate plot lines." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("aabbccdd-eeff-0011-2233-445566778899"), new Guid("717ec5a2-fc14-414d-8d9e-0740895d065b"), "Pride and Prejudice", new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"), "A classic romantic novel that explores the themes of love, marriage, and social standings in the 19th century England." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("bbccddee-ff00-1122-3344-5566778899aa"), new Guid("7819f6a2-db6c-4679-80d2-ec2a2c442a39"), "The Da Vinci Code", new Guid("6a7f5123-4c8e-4fa4-9931-9a4663d215b2"), "A gripping thriller that combines art, history, and religion in an intricate conspiracy theory." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("ccddeeff-0011-2233-4455-66778899aabb"), new Guid("9d54cf49-5b7b-4c5f-ab3c-8b227b6886de"), "Moby Dick", new Guid("3806a2ac-7eba-4a9a-9f34-ac6c403313bd"), "A tale of obsession and revenge set in the backdrop of a perilous whaling expedition." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("ddeeff00-1122-3344-5566-778899aabbcc"), new Guid("3d577e44-8f9a-42c5-94a9-7ea59f5a5b2d"), "The Hunger Games", new Guid("6d7cfe13-8efe-4d0a-b8d6-3cde44b7b523"), "A young girl's fight for survival in a dystopian future where children are forced to fight to the death in a televised event." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("eeff0011-2233-4455-6677-8899aabbccdd"), new Guid("1b8048ed-dba2-43a7-8d95-7c60c67ef86f"), "IT", new Guid("63cf3668-9564-4c0f-8794-5d1e4ac0b021"), "A horror tale about seven children who are terrorized by an evil entity that exploits their fears and phobias." });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "Descriptions" },
                values: new object[] { new Guid("ff001122-3344-5566-7788-99aabbccddee"), new Guid("1b8048ed-dba2-43a7-8d95-7c60c67ef86f"), "The Shining", new Guid("f6c293c6-377c-46f9-8861-7791e67716b5"), "A chilling tale of a family torn apart by the sinister forces in an isolated hotel during winter." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("11223344-5566-7788-99aa-bbccddeeff00"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("22334455-6677-8899-aabb-ccddeeff0011"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("33445566-7788-99aa-bbcc-ddeeff001122"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("44556677-8899-aabb-ccdd-eeff00112233"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("55667788-99aa-bbcc-ddee-ff0011223344"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("66778899-aabb-ccdd-eeff-001122334455"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("778899aa-bbcc-ddee-ff00-112233445566"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("8899aabb-ccdd-eeff-0011-223344556677"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("99aabbcc-ddee-ff00-1122-334455667788"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("aabbccdd-eeff-0011-2233-445566778899"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("bbccddee-ff00-1122-3344-5566778899aa"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("ccddeeff-0011-2233-4455-66778899aabb"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("ddeeff00-1122-3344-5566-778899aabbcc"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("eeff0011-2233-4455-6677-8899aabbccdd"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: new Guid("ff001122-3344-5566-7788-99aabbccddee"));
        }
    }
}
