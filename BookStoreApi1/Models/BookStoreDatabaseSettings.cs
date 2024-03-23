namespace BookStoreApi1.Models
{
    public class BookStoreDatabaseSettings
    {
        public String ConnectionString { get; set; } = null!;
        public String DatabaseName { get; set;} = null!;
        public String BooksCollectionName { get; set; } = null!;


    }
}
