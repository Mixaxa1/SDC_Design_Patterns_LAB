namespace Task3v2ApiSide.ApiSide.BookStorageSystem
{
    public interface IBookStorage
    {
        public Book? GetBook(string name, string authNick = "");
    }
}
