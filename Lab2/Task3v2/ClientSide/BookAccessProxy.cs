using Task3v2ApiSide.ApiSide.BookStorageSystem;
using Task3v2ApiSide.ClientSide.ApiServices;

namespace Task3v2ApiSide.ClientSide
{
    public class BookAccessProxy : IBookApiService
    {
        private IBookApiService _bookService {  get; set; }
        private IPermitionApiService _permitionService { get; set; }
        private IUserApiService _userApiService { get; set; }

        public BookAccessProxy(IBookApiService bookService, IPermitionApiService permitionService, IUserApiService userApiService)
        {
            _bookService = bookService;
            _permitionService = permitionService;
            _userApiService = userApiService;
        }

        public async Task<Book?> GetByNameAsync(string title, string nickname)
        {
            if (await _userApiService.CheckRegistrationAsync(nickname))
            {
                if (await _permitionService.CheckPermitionAsync(nickname, title))
                {
                    return await _bookService.GetByNameAsync(title);
                }
            }

            return null;
        }
    }
}
