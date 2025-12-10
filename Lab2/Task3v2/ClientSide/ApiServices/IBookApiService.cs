using Task3v2ApiSide.ApiSide.BookStorageSystem;

namespace Task3v2ApiSide.ClientSide.ApiServices
{
    public interface IBookApiService
    {
        public Task<Book?> GetByNameAsync(string name, string nickname = "");
    }
}
