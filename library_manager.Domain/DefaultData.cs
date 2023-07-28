using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace library_manager.Domain
{
    public static class DefaultData
    {
        #region Authors
        public static Author AdamSienkiewicz = new Author() { AuthorId = Guid.Parse("3D577E44-8F9A-42C5-94A9-7EA59F5A5B2D"), Firstname = "Adam", LastName = "Sienkiewicz" };
        public static Author HenrykMickiewicz =  new Author() { AuthorId = Guid.Parse("9D54CF49-5B7B-4C5F-AB3C-8B227B6886DE"), Firstname = "Henryk", LastName = "Mickiewicz" };
        public static Author StanisławLem =  new Author() { AuthorId = Guid.Parse("49A10878-472F-4574-9D1E-4A6613C5F456"), Firstname = "Stanisław", LastName = "Lem" };
        public static Author JRowling =  new Author() { AuthorId = Guid.Parse("B8D6A56C-5424-41C8-B634-BE6C47F5B795"), Firstname = "J.K.", LastName = "Rowling" };
        public static Author GeorgeOrwell =  new Author() { AuthorId = Guid.Parse("CC81A20C-BF12-400F-B6A6-8AE6D3B6B857"), Firstname = "George", LastName = "Orwell" };
        public static Author ErnestHemingway =  new Author() { AuthorId = Guid.Parse("39F22B16-3536-42EB-8251-1E5F54BCC7D3"), Firstname = "Ernest", LastName = "Hemingway" };
        public static Author JaneAusten =  new Author() { AuthorId = Guid.Parse("717EC5A2-FC14-414D-8D9E-0740895D065B"), Firstname = "Jane", LastName = "Austen" };
        public static Author FyodorDostoevsky =  new Author() { AuthorId = Guid.Parse("618C8A59-FC69-4A8A-8960-79E1A9D250E8"), Firstname = "Fyodor", LastName = "Dostoevsky" };
        public static Author WilliamShakespeare =  new Author() { AuthorId = Guid.Parse("4A6E7A70-3AEF-4FCD-91C9-441EAEC4A14B"), Firstname = "William", LastName = "Shakespeare" };
        public static Author CharlesDickens =  new Author() { AuthorId = Guid.Parse("2B02AFA9-73B7-4E88-B20A-72FB9F63FCB7"), Firstname = "Charles", LastName = "Dickens" };
        public static Author LeoTolstoy =  new Author() { AuthorId = Guid.Parse("90DA96C8-0964-4C94-A92C-3C20F5DFE9E2"), Firstname = "Leo", LastName = "Tolstoy" };
        public static Author MarkTwain =  new Author() { AuthorId = Guid.Parse("843EF8E3-3C9F-4C6F-A9F3-1E7C105AA892"), Firstname = "Mark", LastName = "Twain" };
        public static Author StephenKing =  new Author() { AuthorId = Guid.Parse("1B8048ED-DBA2-43A7-8D95-7C60C67EF86F"), Firstname = "Stephen", LastName = "King" };
        public static Author AgathaChristie =  new Author() { AuthorId = Guid.Parse("CA1F4F3E-74D1-4E4A-9772-7E1FB4476C1E"), Firstname = "Agatha", LastName = "Christie" };
        public static Author JTolkien =  new Author() { AuthorId = Guid.Parse("0F22D080-A5C1-4C42-BF54-3B6F9D97F22E"), Firstname = "J.R.R.", LastName = "Tolkien" };
        public static Author GeorgeMartin =  new Author() { AuthorId = Guid.Parse("1C6E75FE-9912-4E78-8F6D-CBF3A6B83D8F"), Firstname = "George", LastName = "Martin" };
        public static Author DanBrown =  new Author() { AuthorId = Guid.Parse("7819F6A2-DB6C-4679-80D2-EC2A2C442A39"), Firstname = "Dan", LastName = "Brown" };
        public static Author PauloCoelho =  new Author() { AuthorId = Guid.Parse("33F7E4D7-FA3F-4D5A-9C90-AF28FDF6FEA8"), Firstname = "Paulo", LastName = "Coelho" };
        public static Author HarperLee =  new Author() { AuthorId = Guid.Parse("3B03F0C9-E5C1-4ACD-A0A2-77B1D9E5B4C8"), Firstname = "Harper", LastName = "Lee" };
        public static Author EmilyBront = new Author() { AuthorId = Guid.Parse("0D4628C4-6A42-46EA-9637-109E9FE46D9F"), Firstname = "Emily", LastName = "Bronte" };
        #endregion
        
        #region Categories
        public static Category Fantasy = new Category() { CategoryId = Guid.Parse("6F9619FF-8B86-D011-B42D-00C04FC964FF"), CategoryName = "Fantasy" };
        public static Category ScienceFiction = new Category() { CategoryId = Guid.Parse("6D7CFE13-8EFE-4D0A-B8D6-3CDE44B7B523"), CategoryName = "Science Fiction" };
        public static Category Mystery = new Category() { CategoryId = Guid.Parse("2EC4FE1C-DB01-4EC1-9755-0AF292A8C7F0"), CategoryName = "Mystery" };
        public static Category Thriller = new Category() { CategoryId = Guid.Parse("6A7F5123-4C8E-4FA4-9931-9A4663D215B2"), CategoryName = "Thriller" };
        public static Category Biography = new Category() { CategoryId = Guid.Parse("956F2527-9D0E-40C8-9658-8727F78E6E64"), CategoryName = "Biography" };
        public static Category History = new Category() { CategoryId = Guid.Parse("A6AAFD42-5679-4E8E-8E8B-25CDF483C767"), CategoryName = "History" };
        public static Category Romance = new Category() { CategoryId = Guid.Parse("63CF3668-9564-4C0F-8794-5D1E4AC0B021"), CategoryName = "Romance" };
        public static Category Kids = new Category() { CategoryId = Guid.Parse("3806A2AC-7EBA-4A9A-9F34-AC6C403313BD"), CategoryName = "Kids" };
        public static Category YoungAdult = new Category() { CategoryId = Guid.Parse("5E23987C-4E70-46D6-B971-F8A9AC1CB7F2"), CategoryName = "Young Adult" };
        public static Category NonFiction = new Category() { CategoryId = Guid.Parse("F6C293C6-377C-46F9-8861-7791E67716B5"), CategoryName = "Non-Fiction" };
        #endregion
        
        #region Books
        public static Book Hobbit = new Book() { BookId = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"), BookName = "Hobbit", AuthorId = JTolkien.AuthorId, CategoryId = Fantasy.CategoryId, Descriptions = "An adventure of a lovable hobbit and his friends, set in the fantastical Middle-Earth." };
        public static Book NineteenEightyFour = new Book() { BookId = Guid.Parse("22334455-6677-8899-AABB-CCDDEEFF0011"), BookName = "1984", AuthorId = GeorgeOrwell.AuthorId, CategoryId = ScienceFiction.CategoryId, Descriptions = "A dystopian novel about a future totalitarian society." };
        public static Book AnimalFarm = new Book() { BookId = Guid.Parse("33445566-7788-99AA-BBCC-DDEEFF001122"), BookName = "Animal Farm", AuthorId = GeorgeOrwell.AuthorId, CategoryId = NonFiction.CategoryId, Descriptions = "A political satire and allegory that reflects events leading up to the Russian Revolution." };
        public static Book HarryPotter = new Book() { BookId = Guid.Parse("44556677-8899-AABB-CCDD-EEFF00112233"), BookName = "Harry Potter", AuthorId = JRowling.AuthorId, CategoryId = Fantasy.CategoryId, Descriptions = "A series about a young wizard's journey to fulfill his destiny in a world filled with magic." };
        public static Book LordOfTheRings = new Book() { BookId = Guid.Parse("55667788-99AA-BBCC-DDEE-FF0011223344"), BookName = "The Lord of the Rings", AuthorId = JTolkien.AuthorId, CategoryId = Fantasy.CategoryId, Descriptions = "An epic fantasy trilogy about the fight against the dark lord Sauron." };
        public static Book ToKillAMockingbird = new Book() { BookId = Guid.Parse("66778899-AABB-CCDD-EEFF-001122334455"), BookName = "To Kill a Mockingbird", AuthorId = HarperLee.AuthorId, CategoryId = NonFiction.CategoryId, Descriptions = "A stirring exploration of human morality, depicted through the perspective of a young girl in the Deep South." };
        public static Book TheGreatGatsby = new Book() { BookId = Guid.Parse("778899AA-BBCC-DDEE-FF00-112233445566"), BookName = "The Great Gatsby", AuthorId = JRowling.AuthorId, CategoryId = NonFiction.CategoryId, Descriptions = "A critique of the American Dream set in the backdrop of roaring twenties." };
        public static Book TheCatcherInTheRye = new Book() { BookId = Guid.Parse("8899AABB-CCDD-EEFF-0011-223344556677"), BookName = "The Catcher in the Rye", AuthorId = JaneAusten.AuthorId, CategoryId = Romance.CategoryId, Descriptions = "A novel that perfectly captures teenage angst, rebellion, and feelings of isolation." };
        public static Book AGameOfThrones = new Book() { BookId = Guid.Parse("99AABBCC-DDEE-FF00-1122-334455667788"), BookName = "A Game of Thrones", AuthorId = JTolkien.AuthorId, CategoryId = Fantasy.CategoryId, Descriptions = "A political intrigue set in a fantasy world with a cast of complex characters and intricate plot lines." };
        public static Book PrideAndPrejudice = new Book() { BookId = Guid.Parse("AABBCCDD-EEFF-0011-2233-445566778899"), BookName = "Pride and Prejudice", AuthorId = JaneAusten.AuthorId, CategoryId = Romance.CategoryId, Descriptions = "A classic romantic novel that explores the themes of love, marriage, and social standings in the 19th century England." };
        public static Book TheDaVinciCode = new Book() { BookId = Guid.Parse("BBCCDDEE-FF00-1122-3344-5566778899AA"), BookName = "The Da Vinci Code", AuthorId = DanBrown.AuthorId, CategoryId = Thriller.CategoryId, Descriptions = "A gripping thriller that combines art, history, and religion in an intricate conspiracy theory." };
        public static Book MobyDick = new Book() { BookId = Guid.Parse("CCDDEEFF-0011-2233-4455-66778899AABB"), BookName = "Moby Dick", AuthorId = HenrykMickiewicz.AuthorId, CategoryId = Kids.CategoryId, Descriptions = "A tale of obsession and revenge set in the backdrop of a perilous whaling expedition." };
        public static Book TheHungerGames = new Book() { BookId = Guid.Parse("DDEEFF00-1122-3344-5566-778899AABBCC"), BookName = "The Hunger Games", AuthorId = AdamSienkiewicz.AuthorId, CategoryId = ScienceFiction.CategoryId, Descriptions = "A young girl's fight for survival in a dystopian future where children are forced to fight to the death in a televised event." };
        public static Book IT = new Book() { BookId = Guid.Parse("EEFF0011-2233-4455-6677-8899AABBCCDD"), BookName = "IT", AuthorId = StephenKing.AuthorId, CategoryId = Romance.CategoryId, Descriptions = "A horror tale about seven children who are terrorized by an evil entity that exploits their fears and phobias." };
        public static Book TheShining = new Book() { BookId = Guid.Parse("FF001122-3344-5566-7788-99AABBCCDDEE"), BookName = "The Shining", AuthorId = StephenKing.AuthorId, CategoryId = NonFiction.CategoryId, Descriptions = "A chilling tale of a family torn apart by the sinister forces in an isolated hotel during winter." };
        #endregion
        
        public static IEnumerable<Author> GetAllAuthors()
        {
            var fields = typeof(DefaultData)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.FieldType.IsAssignableTo(typeof(Author)));
    
            foreach (var field in fields)
            {
                yield return field.GetValue(null) as Author;
            }
        }
        
        public static IEnumerable<Category> GetAllCategories()
        {
            var fields = typeof(DefaultData)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.FieldType.IsAssignableTo(typeof(Category)));
    
            foreach (var field in fields)
            {
                yield return field.GetValue(null) as Category;
            }
        }
        
        public static IEnumerable<Book> GetAllBooks()
        {
            var fields = typeof(DefaultData)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.FieldType.IsAssignableTo(typeof(Book)));
    
            foreach (var field in fields)
            {
                yield return field.GetValue(null) as Book;
            }
        }
    }
}