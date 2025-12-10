using System.Web;
using Newtonsoft.Json;

namespace Task3v2ApiSide.ClientSide.ApiServices
{
    public class PermitionApiService : IPermitionApiService
    {
        private string _baseRoute = "https://localhost:7278/Permitions/";

        public async Task<bool> CheckPermitionAsync(string nickname, string book)
        {
            var builder = new UriBuilder(_baseRoute + nickname);
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["book"] = book;
            builder.Query = query.ToString();

            var client = new HttpClient();

            var responce = await client.GetAsync(builder.ToString());
            var content = await responce.Content.ReadAsStringAsync();

           return bool.Parse(content);
        }
    }
}
