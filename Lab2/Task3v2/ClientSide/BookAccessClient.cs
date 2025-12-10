using System.Threading.Tasks;
using Task3v2ApiSide.ApiSide.BookStorageSystem;
using Task3v2ApiSide.ClientSide.ApiServices;

namespace Task3v2ApiSide.ClientSide
{
    public class BookAccessClient
    {
        private IBookApiService _bookApiService;
        private IUserApiService _userApiService;

        private string? _authorizedUser = null;

        public BookAccessClient(IBookApiService bookApiService, IUserApiService userApiService)
        {
            _bookApiService = bookApiService;
            _userApiService = userApiService;
        }

        public async Task Authorize(string login, string password)
        {
            if (_authorizedUser == null)
            {
                var result = await _userApiService.AuthorizeAsync(login, password);

                if (result != null)
                {
                    _authorizedUser = result;
                }
            }

            else
            {
                Console.WriteLine("User already authorized");
            }
        }

        public void ExitAccount()
        {
            _authorizedUser = null;
        }

        public async Task<Book?> RequestBookByName(string title) 
        {
            return await _bookApiService.GetByNameAsync(title, _authorizedUser);
        }
    }
}
