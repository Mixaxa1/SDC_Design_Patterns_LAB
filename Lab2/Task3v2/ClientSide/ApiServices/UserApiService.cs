using System.Web;
using Newtonsoft.Json;

namespace Task3v2ApiSide.ClientSide.ApiServices
{
    public class UserApiService : IUserApiService
    {
        private string _baseRoute = "https://localhost:7278/User/";

        public async Task<string?> AuthorizeAsync(string loign, string password)
        {
            var builder = new UriBuilder(_baseRoute + loign);
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["password"] = password;
            builder.Query = query.ToString();

            var client = new HttpClient();

            var responce = await client.GetAsync(builder.ToString());
            var result = await responce.Content.ReadAsStringAsync();

           return result;
        }

        public async Task<bool> CheckRegistrationAsync(string nickname)
        {
            var client = new HttpClient();

            var responce = await client.GetAsync(new Uri(_baseRoute + "checkReg/" + nickname));
            var content = await responce.Content.ReadAsStringAsync();

            Boolean.TryParse(content, out var result);

            return result;
        }
    }
}
