using System.Web;
using Newtonsoft.Json;
using Task3v2ApiSide.ApiSide.BookStorageSystem;

namespace Task3v2ApiSide.ClientSide.ApiServices
{
    public class BookApiService : IBookApiService
    {
        private string _baseRoute = "https://localhost:7278/BookStorage/";

        public async Task<Book?> GetByNameAsync(string title, string nickname = "")
        {
            var client = new HttpClient();

            var responce = await client.GetAsync(new Uri(_baseRoute + title));
            var content = await responce.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Book?>(content);

            return result;
        }
    }
}
