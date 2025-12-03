using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BookStorageSystem;
using Task3.UserPermitionStorage;
using Task3.UserStorageSystem;

namespace Task3
{
    public class AuthProxy : IBookStorage
    {
        private IBookStorage _bookStorage;
        private IUserAuthorizationService _userAuthorizationService;
        private IUserPermitionService _userPermitionService;
        private string _authorizedUser = "";

        public AuthProxy(IBookStorage bookStorage, IUserAuthorizationService userAuthorizationService, IUserPermitionService userPermitionService)
        {
            _bookStorage = bookStorage;
            _userAuthorizationService = userAuthorizationService;
            _userPermitionService = userPermitionService;
        }

        public Book? GetBook(string bookName, string nickName)
        {
            if (_userAuthorizationService.CheckRegistration(nickName))
            {
                if (_userPermitionService.CheckPermition(nickName, bookName))
                {
                    return _bookStorage.GetBook(bookName);
                }
            }
            return null;
        }
    }
}
