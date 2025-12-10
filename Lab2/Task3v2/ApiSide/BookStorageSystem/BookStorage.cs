namespace Task3v2ApiSide.ApiSide.BookStorageSystem
{
    public class BookStorage : IBookStorage
    {
        private Dictionary<string, Book> _books = new Dictionary<string, Book>();

        public BookStorage()
        {
            Initialize();
        }

        public void Initialize()
        {
            _books.Clear();

            var books = new List<Book>()
            {
                new Book() {Title = "Jaba", Description = "IDK"},
                new Book() {Title = "Test1", Description = "NoTest2"},
                new Book() {Title = "AbsoluteBook", Description = "Unknown" }
            };

            foreach (var book in books)
            {
                _books.Add(book.Title, book);
            }
        }

        public Book? GetBook(string name, string authNick="")
        {
            return _books[name];
        }
    }
}
