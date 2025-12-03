using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BookStorageSystem;
using Task3.Storage;
using Task3.UserStorageSystem;

namespace Task3
{
    public class BookAccessClient
    {
        private IBookStorage _bookStorage;
        private IUserAuthorizationService _userAuthorizaton;
        private string? _authorizedUser = null;

        public BookAccessClient(IBookStorage bookStorage, IUserAuthorizationService userAuthorizationService)
        {
            _bookStorage = bookStorage;
            _userAuthorizaton = userAuthorizationService;
        }

        public void Authorize(string login, string password)
        {
            if (_authorizedUser == null)
            {
                var result = _userAuthorizaton.Authorize(login, password);

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

        public Book? RequestBookByName(string name)
        {
            return _bookStorage.GetBook(name, _authorizedUser);
        }
    }
}
